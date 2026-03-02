using ClinicManagementSystem.BL.ViewModels.Appointments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Appointments
{
    public interface IAppointmentManager
    {
         
        
        void Add(AppointmentAddVM appointmentAddVM);
       

        IEnumerable<DoctorAppointmentsVM> GetAppointmentsByDoctorIdAndDate(int doctorId, DateOnly date);

        IEnumerable<AppointmentReadVM> GetAllWithRelations();
    }
}
