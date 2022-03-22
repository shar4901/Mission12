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
        [Required(ErrorMessage = "Enter a group name")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Enter a group size 1-15")]
        [Range(1, 15)]
        public int GroupSize { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
        //Potentially take out if problems with format
        [Phone (ErrorMessage ="Enter a valid phone number")]
        public string Phone { get; set; }

    }
}
