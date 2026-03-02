using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Appointments
{
    public interface IAppointmentRepository: IGenericRepository<Appointment>
    {
        IEnumerable<Appointment> GetAppointmentsByDoctorIdAndDate (int doctorId, DateOnly date);
        IEnumerable<Appointment>  GetAllWithRelations ();   
    }
}
