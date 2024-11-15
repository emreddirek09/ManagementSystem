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
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public int RoleId { get; set; }
        public UserRole Role { get; set; } // User ile UserRole arasında bire-bir ilişki

        public ICollection<Appointment> Appointments { get; set; } // User ile Appointment arasında bire-çoğa ilişki
    }
}
