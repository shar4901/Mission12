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
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 09:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 10:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 11:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 12:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 13:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 14:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 15:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 16:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 17:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 18:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 19:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/5/2022 20:00:00"), AppointmentId = null },

                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 08:00:00"), AppointmentId = null},
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 09:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 10:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 11:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 12:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 13:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 14:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 15:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 16:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 17:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 18:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 19:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/6/2022 20:00:00"), AppointmentId = null },

                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 08:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 09:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 10:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 11:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 12:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 13:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 14:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 15:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 16:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 17:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 18:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 19:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/7/2022 20:00:00"), AppointmentId = null },

                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 08:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 09:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 10:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 11:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 12:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 13:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 14:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 15:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 16:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 17:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 18:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 19:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/8/2022 20:00:00"), AppointmentId = null },


                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 08:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 09:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 10:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 11:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 12:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 13:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 14:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 15:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 16:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 17:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 18:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 19:00:00"), AppointmentId = null },
                new TimeSlot { AppointmentDateTime = DateTime.Parse("4/9/2022 20:00:00"), AppointmentId = null }
                );


        }
    }
}
 