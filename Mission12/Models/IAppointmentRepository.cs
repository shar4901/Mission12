using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        IQueryable<TimeSlot> Timeslots { get; }

        //public void SaveAppointment(Appointment appointment);


    }
}
