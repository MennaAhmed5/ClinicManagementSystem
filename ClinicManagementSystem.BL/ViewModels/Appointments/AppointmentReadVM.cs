using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Appointments
{
    public class AppointmentReadVM
    {
        public int Id { get; set; }
         
        public string? DoctorName { get; set; }

      
        public string? PatientName { get; set; }

         
        public DateOnly AppointmentDate { get; set; }
    
        public TimeOnly StartTime { get; set; }

       
        public TimeOnly EndTime { get; set; }

        

    }
}
