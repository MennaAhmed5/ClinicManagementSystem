using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Patients
{
    public class PatientReadVM
    {
        public int Id { get; set; }

      
        public string Name { get; set; } = string.Empty;

        public DateOnly BirthDate { get; set; }

        
        public string Phone { get; set; } = string.Empty;


        public PatientReadVM(int id, string name, DateOnly birthdate, string phone)
        {
            Id = id;
            Name = name;
            BirthDate = birthdate;
            Phone = phone;
        }
        public PatientReadVM()
        {

        }

     }
}
