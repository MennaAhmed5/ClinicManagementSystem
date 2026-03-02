using ClinicManagementSystem.BL.ViewModels.Appointments;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Appointments
{
    public class ApointmentManager : IAppointmentManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApointmentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(AppointmentAddVM appointmentAddVM)
        {
            Appointment appointment = new Appointment()
            {
                PatientId = appointmentAddVM.Patient.Id,
                DoctorId = appointmentAddVM.DoctorId,
                AppointmentDate = appointmentAddVM.AppointmentDate,
                StartTime = appointmentAddVM.StartTime,
                EndTime = appointmentAddVM.StartTime.AddMinutes(30)
            };
            _unitOfWork.AppointmentRepository.Add(appointment);
            _unitOfWork.SaveChanges();
        }

    

        public IEnumerable<AppointmentReadVM> GetAllWithRelations()
        {
            var appointments = _unitOfWork.AppointmentRepository.GetAllWithRelations();
            return appointments.Select(x => new AppointmentReadVM() { Id = x.Id, DoctorName = x.Doctor.Name, PatientName = x.Patient.Name, StartTime = x.StartTime, EndTime = x.EndTime, AppointmentDate = x.AppointmentDate });
        }

        public IEnumerable<DoctorAppointmentsVM> GetAppointmentsByDoctorIdAndDate(int doctorId, DateOnly date)
        {
           var appointments = _unitOfWork.AppointmentRepository.GetAppointmentsByDoctorIdAndDate(doctorId, date);
            IEnumerable<DoctorAppointmentsVM> appointmentsVM = appointments.Select(a => new DoctorAppointmentsVM(a.Id, a.DoctorId,a.PatientId, a.AppointmentDate, a.StartTime, a.EndTime ));
            return appointmentsVM;  
        }

         
    }
}
