using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15)]
        public int GroupSize { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        //Potentially take out if problems with format
        [Phone]
        public string Phone { get; set; }

    }
}
