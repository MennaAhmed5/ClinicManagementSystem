using ClinicManagementSystem.DAL.Data.Context;
using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Repositories.Generic;
using ClinicManagementSystem.DAL.Repositories.Patients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Schedules
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
        private readonly AppDbContext _context;
        public ScheduleRepository(AppDbContext context) : base(context)
        {
            _context = context; 
        }

        public IEnumerable<Schedule> GetByDoctorId(int doctorId)
        {
           return _context.Schedules.Where(s=>s.DoctorId == doctorId);
        }

        public Schedule? GetScheduleByDoctorIdAndDay(int doctorId, WorkDay day)
        {
            return _context.Schedules.Where( s=> s.DoctorId == doctorId && s.Day == day).FirstOrDefault();
        }
    }
}
