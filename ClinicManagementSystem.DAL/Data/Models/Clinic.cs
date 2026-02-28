using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.DAL.Data.Models
{
    public class Clinic
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;

        public ICollection<Doctor> Doctors { get; set; } = null!;
    }
}
