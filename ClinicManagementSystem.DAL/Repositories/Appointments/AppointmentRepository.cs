using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace ClinicManagementSystem.DAL.Repositories.Appointments
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        private readonly AppDbContext _context;
        public AppointmentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Appointment> GetAllWithRelations()
        {
            return _context.Appointments.Include(a => a.Patient)
                   .Include(a => a.Doctor)
                   .ToList();
        }

        public IEnumerable<Appointment> GetAppointmentsByDoctorIdAndDate(int doctorId, DateOnly date)
        {
           return _context.Appointments.Where(a=>a.DoctorId == doctorId && a.AppointmentDate == date);
        }
          
    }
}
