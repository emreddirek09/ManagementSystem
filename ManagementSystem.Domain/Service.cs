using ManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain
{
    public class Service:BaseEntity
    { 
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<Appointment> Appointments { get; set; } // Appointment ile bire-çoğa ilişki
    }
}
