﻿using Microsoft.EntityFrameworkCore;
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
}
}
