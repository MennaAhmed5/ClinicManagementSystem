using ClinicManagementSystem.DAL.Repositories.Appointments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IAppointmentRepository AppointmentRepository { get;}

        void SaveChanges();
         
    }
}
