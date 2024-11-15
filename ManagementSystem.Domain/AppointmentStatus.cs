using ManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain
{
    public class AppointmentStatus : BaseEntity
    {  
        [Required]
        [MaxLength(50)]
        public string StatusName { get; set; }
        public ICollection<Appointment> Appointments { get; set; } // Appointment ile bire-çoğa ilişki
    }
}
