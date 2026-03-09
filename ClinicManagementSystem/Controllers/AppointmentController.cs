using ClinicManagementSystem.BL.Managers.Appointments;
using ClinicManagementSystem.BL.Managers.Doctors;
using ClinicManagementSystem.BL.Managers.Patients;
using ClinicManagementSystem.BL.Managers.Schedules;
using ClinicManagementSystem.BL.ViewModels.Appointments;
using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClinicManagementSystem.MVC.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IDoctorManager _doctorManager;
        private readonly IPatientManager _patientManager;
        private readonly IScheduleManager _scheduleManager;
        private readonly IAppointmentManager _appointmentManager;
        private readonly IConfiguration _configuration;

        public AppointmentController(IDoctorManager doctorManager , IPatientManager patientManager, IScheduleManager scheduleManager, IAppointmentManager appointmentManager, IConfiguration configuration)
        {
             _doctorManager = doctorManager;
            _patientManager = patientManager;
            _scheduleManager = scheduleManager;
            _appointmentManager = appointmentManager;
            _configuration = configuration;


        }
        public IActionResult Index()
        {
          var appointments   = _appointmentManager.GetAllWithRelations().ToList();
          return View(appointments);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Doctors = _doctorManager.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Add(AppointmentAddVM appointmentAddVM)
        {
            if (!ModelState.IsValid)
                return View("Add",appointmentAddVM);

            if (appointmentAddVM.Patient != null)
            {
                //check if patient exist 
                var patient = _patientManager.GetPatientbyPhone(appointmentAddVM.Patient.Phone);

                //if not exist add it  then get 
                if (patient == null)
                {
                    _patientManager.Add(appointmentAddVM.Patient);
                    patient = _patientManager.GetPatientbyPhone(appointmentAddVM.Patient.Phone);


                }
                if (patient != null)
                    appointmentAddVM.Patient.Id = patient.Id;

                //get doctor appointment
                var appointments = _appointmentManager.GetAppointmentsByDoctorIdAndDate(appointmentAddVM.DoctorId, appointmentAddVM.AppointmentDate)
                                .Select(a => new { a.StartTime, a.EndTime }).ToList();


                //overlap 
                var overlap = appointments.Where(x => x.StartTime == appointmentAddVM.StartTime && x.EndTime == appointmentAddVM.StartTime.AddMinutes(30)).ToList();


                if (overlap.Any())
                {
                    return Json(new { message = "This time is not available. Please choose another time.", Status = "fail" });
                }

                //Add Appointment  in db 
                _appointmentManager.Add(appointmentAddVM);
               

            }

            return Json(new { Status = "Success", Message= "Appointment created successfully." });
        }

        public IActionResult GetAvailableTimeSlots(int doctorId, DateOnly date)
        {
            //check parameters values
            if(doctorId == 0 || date == default(DateOnly))
                
            return Json(new { Status = "fail", Data = new List<TimeOnly>() });
            // Get schedule of selected doctor by doctorId and day

            var schedule = _scheduleManager.GetByDoctorIdAndDay(doctorId, (WorkDay)date.DayOfWeek);

            if(schedule == null)
                return Json(new { Status = "fail", Data = new List<TimeOnly>() });

            //Get booked appointments by doctorId and date
            var appointments = _appointmentManager.GetAppointmentsByDoctorIdAndDate(doctorId, date)
                                .Select(a=> new {a.StartTime, a.EndTime}).ToList();



            //Generate free slots 
            int DefaultVisitLength = Convert.ToInt32(_configuration["ClincSetting:DefaultVisitLength"]);
            var availableSlots = new List<TimeOnly>();
            var slotDuration = TimeSpan.FromMinutes(DefaultVisitLength);
            var currentTime = schedule.StartTime;


            while (currentTime.Add(slotDuration) <= schedule.EndTime)
            {
                bool overlaps = appointments.Any(a =>
                    TimeOnlyOverlaps(currentTime, currentTime.Add(slotDuration), a.StartTime, a.EndTime)
                );

                if (!overlaps)
                    availableSlots.Add(currentTime);

                currentTime = currentTime.AddMinutes(DefaultVisitLength);  
            }


            return Json(new { success = true, data = availableSlots });
        }

        #region Helpers
        private bool TimeOnlyOverlaps(TimeOnly start1, TimeOnly end1, TimeOnly start2, TimeOnly end2)
        {
            return start1 < end2 && start2 < end1;
        }
        #endregion
    }

}

