using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Appointments
{
    public class DoctorAppointmentsVM
    {
        public int Id { get; set; }

        
        public int DoctorId { get; set; }

        
        public int PatientId { get; set; }

        
        public DateOnly AppointmentDate { get; set; }
         
        public TimeOnly StartTime { get; set; }
 
        public TimeOnly EndTime { get; set; }

        
         

  
        public DoctorAppointmentsVM()
        {

        }
        public DoctorAppointmentsVM(int id, int doctorId, int patientId, DateOnly appointmentDate, TimeOnly startTime, TimeOnly endTime)
        {
            Id = id;
            DoctorId = doctorId;
            PatientId = patientId;  
            AppointmentDate = appointmentDate;
            StartTime = startTime;
            EndTime = endTime;  
         

        }
    }
}
