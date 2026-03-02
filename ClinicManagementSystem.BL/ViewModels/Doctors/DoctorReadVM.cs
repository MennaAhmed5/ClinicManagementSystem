using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Doctors
{
    public class DoctorReadVM
    {
        public int Id { get; set; }
 
        public string Name { get; set; } = string.Empty;

      
        public string Specialization { get; set; } = string.Empty;

       
        public string Email { get; set; } = string.Empty;

       
        public string Phone { get; set; } = string.Empty;

        public int ClinicId { get; set; }

        public DoctorReadVM(int id, string name, string specialization, string email, string phone, int clinicId)
        {
            Id = id;
            Name = name;    
            Specialization = specialization;
            Email = email;
            Phone = phone;
            ClinicId = clinicId;
        }
    }
}
