using ClinicManagementSystem.DAL.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.DAL.Data.Models
{
    public class Schedule
    {
         
          public int DoctorId { get; set; }

          [Required]
          public WorkDay Day { get; set; }   
          
          [Required]    
          public TimeOnly StartTime { get; set; }

          [Required]
          public TimeOnly EndTime { get; set; }

          public virtual Doctor Doctor { get; set; } = null!;
    }
}
