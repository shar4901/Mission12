using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentContext context { get; set; }

        public EFAppointmentRepository(AppointmentContext temp) 
        {
            context = temp;
        }

        public IQueryable<TimeSlot> Timeslots => context.TimeSlots.Include(x => x.Appointment);

        public IQueryable<Appointment> Appointments => context.Appointments.Include(x => x.AppointmentId);

    }
}
