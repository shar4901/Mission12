using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext()
        {

        }

        public AppointmentContext(DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments {get; set;}
        public DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, Email = "test@test.com", GroupName = "Farquad Squad", GroupSize = 4, Phone = "801-123-1234" }
                );

            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 08:00:00"), AppointmentId = 1 },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 09:00:00"), AppointmentId = null }

                );


        }
    }
}
 