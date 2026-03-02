using ClinicManagementSystem.DAL.Repositories.Appointments;
using ClinicManagementSystem.DAL.Repositories.Doctors;
using ClinicManagementSystem.DAL.Repositories.Patients;
using ClinicManagementSystem.DAL.Repositories.Schedules;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IAppointmentRepository AppointmentRepository { get;}

        public IDoctorRepository DoctorRepository { get; }

        public IPatientRepository PatientRepository { get; }


        public IScheduleRepository ScheduleRepository { get; }

        void SaveChanges();
         
    }
}
