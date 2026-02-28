using ClinicManagementSystem.BL.ViewModels.Appointments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.BL.Managers.Appointments
{
    public interface IAppointmentManager
    {
        IEnumerable<AppointmentReadVM> GetAll();
        AppointmentEditVM? GetForEditById(int id);
        void Add(AppointmentAddVM appointmentAddVM);
        void Edit(AppointmentEditVM appointmentEditVM);
        void Delete(int id);
    }
}
