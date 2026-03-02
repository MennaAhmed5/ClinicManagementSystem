using ClinicManagementSystem.BL.ViewModels.Appointments;
using ClinicManagementSystem.BL.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Patients
{
    public interface IPatientManager
    {
       
        void Add(PatientAddVM patientAddVM);

        PatientReadVM? GetPatientbyNameAndBirthdate(string name, DateOnly birthdate);
       
    }
}
