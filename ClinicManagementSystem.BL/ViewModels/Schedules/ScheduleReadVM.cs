using ClinicManagementSystem.DAL.Data.Enums;
using ClinicManagementSystem.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClinicManagementSystem.BL.ViewModels.Schedules
{
    public class ScheduleReadVM
    {
        public int DoctorId { get; set; }        
        public WorkDay Day { get; set; }
 
        public TimeOnly StartTime { get; set; }
   
        public TimeOnly EndTime { get; set; }

        public ScheduleReadVM()
        {

        }
        public ScheduleReadVM(int doctorId, WorkDay day, TimeOnly startTime, TimeOnly endTime)
        {
            DoctorId = doctorId;
            Day = day;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
