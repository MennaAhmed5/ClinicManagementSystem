using ClinicManagementSystem.BL.ViewModels.Doctors;
using ClinicManagementSystem.BL.ViewModels.Patients;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Patients
{
    public class PatientManager : IPatientManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(PatientAddVM patientAddVM)
        {
            Patient patient = new Patient()
            {
                Name = patientAddVM.Name,
                BirthDate = patientAddVM.BirthDate,
                Phone = patientAddVM.Phone
            };
            _unitOfWork.PatientRepository.Add(patient);
            _unitOfWork.SaveChanges();
        }
        

        public PatientReadVM? GetPatientbyNameAndBirthdate(string name, DateOnly birthDate)
        {
            
            var Patient = _unitOfWork.PatientRepository.GetPatientbyNameAndBirthdate(name, birthDate);
            
            if (Patient == null) return null;   

            var PatientVM = new PatientReadVM()
            {
                Id = Patient.Id,
                Name = Patient.Name,
                BirthDate = Patient.BirthDate,
                Phone = Patient.Phone
            };
            return PatientVM;
        }
    }
}
