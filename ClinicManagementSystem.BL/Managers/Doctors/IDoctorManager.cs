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
      
      
         
    }
}
