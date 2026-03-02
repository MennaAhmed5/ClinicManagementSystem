using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.DAL.Repositories.Patients
{
    public interface IPatientRepository: IGenericRepository<Patient>
    {
         Patient? GetPatientbyNameAndBirthdate(string name, DateOnly birthDate);
         
    }
}
