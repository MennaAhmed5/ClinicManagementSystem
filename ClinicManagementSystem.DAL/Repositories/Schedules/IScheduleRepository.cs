using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Schedules
{
    public interface IScheduleRepository : IGenericRepository<Schedule>
    {
        IEnumerable<Schedule> GetByDoctorId(int doctorId);
        Schedule? GetScheduleByDoctorIdAndDay(int doctorId, WorkDay day);
    }
}
