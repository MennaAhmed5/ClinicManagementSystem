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
        private readonly AppDbContext _context;
        public PatientRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Patient? GetPatientbyNameAndBirthdate(string name, DateOnly birthDate)
        {
           return _context.Patients.Where(p => p.Name.ToLower() == name.ToLower() && p.BirthDate == birthDate).FirstOrDefault();
        }
    }
}
