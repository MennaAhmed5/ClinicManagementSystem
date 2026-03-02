using ClinicManagementSystem.BL.ViewModels.Schedules;
using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Schedules
{
    public interface IScheduleManager
    {
        IEnumerable<ScheduleReadVM> GetByDoctorId(int  doctorId);
        ScheduleReadVM? GetByDoctorIdAndDay (int doctorId, WorkDay day);
            
    }
}
