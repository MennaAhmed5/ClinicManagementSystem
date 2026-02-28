using ClinicManagementSystem.DAL.Data.Context;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Repositories.Appointments;
using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Patients
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext context) : base(context)
        {
        }
    }
}
