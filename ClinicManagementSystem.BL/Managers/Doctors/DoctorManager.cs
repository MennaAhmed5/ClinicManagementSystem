using ClinicManagementSystem.BL.ViewModels.Doctors;
using ClinicManagementSystem.DAL.Data.Models;
using ClinicManagementSystem.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Doctors
{
    public class DoctorManager : IDoctorManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public DoctorManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        

        public IEnumerable<DoctorReadVM> GetAll()
        {
            IEnumerable<Doctor> doctors = _unitOfWork.DoctorRepository.GetAll();
            IEnumerable<DoctorReadVM> doctorsVM = doctors.Select(d => new DoctorReadVM(d.Id, d.Name, d.Specialization, d.Email, d.Phone, d.ClinicId));
            return doctorsVM;
        }

       
    }
}
