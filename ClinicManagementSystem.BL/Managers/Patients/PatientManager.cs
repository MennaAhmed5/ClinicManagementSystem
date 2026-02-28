using ClinicManagementSystem.BL.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Patients
{
    public class PatientManager : IPatientManager
    {
        public void Add(PatientAddVM patientAddVM)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PatientEditVM patientEditVM)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientReadVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public PatientEditVM? GetForEditById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
