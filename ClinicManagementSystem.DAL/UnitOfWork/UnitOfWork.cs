using ClinicManagementSystem.DAL.Data.Context;
using ClinicManagementSystem.DAL.Repositories.Appointments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly AppDbContext _context;
        public IAppointmentRepository AppointmentRepository { get; }

        public UnitOfWork(AppDbContext context, IAppointmentRepository appointmentRepository)
        {
            _context = context;
            AppointmentRepository = appointmentRepository;  
        }
        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }
    }
}
