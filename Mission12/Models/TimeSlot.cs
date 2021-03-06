using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public DateTime AppointmentDateTime { get; set; }

        public int? AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
    }
}
