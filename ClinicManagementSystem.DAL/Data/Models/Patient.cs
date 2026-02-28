using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.DAL.Data.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; } = string.Empty;

        public virtual ICollection<Appointment> Appointments { get; set; } = [];

    }
}
