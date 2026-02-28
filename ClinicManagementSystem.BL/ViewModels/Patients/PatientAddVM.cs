using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Patients
{
    public class PatientAddVM
    {
        

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; } = string.Empty;

    }
}
