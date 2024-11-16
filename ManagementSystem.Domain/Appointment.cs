using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementSystem.Domain.Common;

namespace ManagementSystem.Domain
{
    public class Appointment : BaseEntity
    { 

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string StatusId { get; set; }
        [ForeignKey("StatusId")]
        public AppointmentStatus Status { get; set; } // Appointment ile AppointmentStatus arasında ilişki

        [Required]
        public string ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Service Service { get; set; } // Appointment ile Service arasında ilişki

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } // Appointment ile User arasında ilişki
    }
}
