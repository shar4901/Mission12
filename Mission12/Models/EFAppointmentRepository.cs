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

        public void SaveAppointment(Appointment appointment, DateTime timeId )
        {
            // cast to datetime

            if (appointment.AppointmentId == 0)
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();

                //grab timeslot to update
                TimeSlot timeslot = context.TimeSlots.Where(x => x.AppointmentDateTime == timeId).FirstOrDefault();


                timeslot.AppointmentId = appointment.AppointmentId;
            }

            context.SaveChanges();
        }

        public void DeleteAppointment(int AppId)
        {// delete appointment object, removee apptid from the timeslot so that it can get added back to the list of avaiilable appts
            Appointment app = context.Appointments.Where(x => x.AppointmentId == AppId).FirstOrDefault();
            TimeSlot timeslot = context.TimeSlots.Where(x => x.AppointmentId == AppId).FirstOrDefault();
            timeslot.AppointmentId = null;
            context.Remove(app);
            context.SaveChanges();
        }

        public void EditAppointment(Appointment appointment)
        {
            //Appointment app = context.Appointments.Single(x => x.AppointmentId == AppId);
            //TimeSlot timeslot = context.TimeSlots.Single(x => x.AppointmentId == AppId);

            //Models.Appointment appointment = context.Appointments.Single(x => x.AppointmentId == AppId);

            context.Update(appointment);
        }
    }
}
