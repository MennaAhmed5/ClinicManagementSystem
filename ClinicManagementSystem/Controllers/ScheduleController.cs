using ClinicManagementSystem.BL.Managers.Doctors;
using ClinicManagementSystem.BL.Managers.Patients;
using ClinicManagementSystem.BL.Managers.Schedules;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagementSystem.MVC.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleManager _scheduleManager;
        public ScheduleController(IScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager; 
        }
        public IActionResult GetSchedulesByDoctorId(int doctorId)
        {
           var schedules =  _scheduleManager.GetByDoctorId(doctorId);

            return Json(new {Data = schedules, Status = "Success"});
        }
    }
}
