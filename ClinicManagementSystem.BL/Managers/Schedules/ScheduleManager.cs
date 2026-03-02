using ClinicManagementSystem.BL.ViewModels.Patients;
using ClinicManagementSystem.BL.ViewModels.Schedules;
using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Schedules
{
    public class ScheduleManager : IScheduleManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public ScheduleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<ScheduleReadVM> GetByDoctorId(int doctorId)
        {

           IEnumerable<Schedule> schedules= _unitOfWork.ScheduleRepository.GetByDoctorId(doctorId);
           IEnumerable<ScheduleReadVM> schedulesVM = schedules.Select(s=>new ScheduleReadVM(s.DoctorId, s.Day, s.StartTime,s.EndTime));
           return schedulesVM; 
        }

        public ScheduleReadVM? GetByDoctorIdAndDay(int doctorId, WorkDay day)
        {
            var Schedule = _unitOfWork.ScheduleRepository.GetScheduleByDoctorIdAndDay(doctorId, day);

            if (Schedule == null) return null;

            var ScheduleVM = new ScheduleReadVM()
            {
                DoctorId = Schedule.DoctorId,
                Day = Schedule.Day,
                StartTime = Schedule.StartTime,
                EndTime = Schedule.EndTime,
            };
            return ScheduleVM;
        }
    }
}
