using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Appointments
{
    public class AppointmentAddVM
    {

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public DateOnly AppointmentDate { get; set; }
        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }


    }
}
