using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Doctors
{
    public class DoctorAddVM
    {
         
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Specialization { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Phone Number")]
        [Required]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; } = string.Empty;

        public int ClinicId { get; set; }
    }
}
