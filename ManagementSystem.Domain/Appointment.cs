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
        public string AppointmentName { get; set; }         
        public DateTime AppointmentDate { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } // Appointment ile User arasında ilişki
    }
}
