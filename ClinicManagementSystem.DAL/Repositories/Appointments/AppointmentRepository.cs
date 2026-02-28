using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Data.Context;
namespace ClinicManagementSystem.DAL.Repositories.Appointments
{
    public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
