using ClinicManagementSystem.DAL.Data.Context;
using ClinicManagementSystem.DAL.Repositories.Appointments;
using ClinicManagementSystem.DAL.Repositories.Doctors;
using ClinicManagementSystem.DAL.Repositories.Patients;
using ClinicManagementSystem.DAL.Repositories.Schedules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly AppDbContext _context;
        public IAppointmentRepository AppointmentRepository { get; }
        public IDoctorRepository DoctorRepository { get; }

        public IPatientRepository PatientRepository { get; }

        public IScheduleRepository ScheduleRepository { get; }

        public UnitOfWork(AppDbContext context, IAppointmentRepository appointmentRepository, IDoctorRepository doctorRepository, IPatientRepository patientRepository, IScheduleRepository scheduleRepository)
        {
            _context = context;
            AppointmentRepository = appointmentRepository;  
            DoctorRepository = doctorRepository;    
            PatientRepository = patientRepository; 
            ScheduleRepository = scheduleRepository;    
        }
        public void SaveChanges()
        {
            _context.SaveChanges(); 
        }
    }
}
