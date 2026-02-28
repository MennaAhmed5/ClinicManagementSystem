using ClinicManagementSystem.BL.ViewModels.Appointments;
using ClinicManagementSystem.BL.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Patients
{
    public interface IPatientManager
    {
        IEnumerable<PatientReadVM> GetAll();
        PatientEditVM? GetForEditById(int id);
        void Add(PatientAddVM patientAddVM);
        void Edit(PatientEditVM patientEditVM);
        void Delete(int id);
    }
}
