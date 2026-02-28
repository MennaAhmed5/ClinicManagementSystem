using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.DAL.Data.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Specialization { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; }  = string.Empty;

        [Display(Name = "Phone Number")]
        [Required]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; } = string.Empty;

        public int ClinicId { get; set; }

        public virtual Clinic Clinic { get; set; } = null!;

        public virtual ICollection<Schedule> Schedules { get; set; } = [];
        public virtual ICollection<Appointment> Appointments { get; set; } = [];

    }
}
