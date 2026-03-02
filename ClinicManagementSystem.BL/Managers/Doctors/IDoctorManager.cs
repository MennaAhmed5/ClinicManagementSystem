using ClinicManagementSystem.BL.ViewModels.Doctors;
using ClinicManagementSystem.BL.ViewModels.Patients;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Doctors
{
    public interface IDoctorManager
    {
        IEnumerable<DoctorReadVM> GetAll();
        DoctorEditVM? GetForEditById(int id);
        void Add(DoctorAddVM doctorAddVM);
        void Edit(DoctorEditVM doctorEditVM);
        void Delete(int id);
    }
}
