using ManagementSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain
{
    public class UserRole:BaseEntity
    {  
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; } // User ile bire-çoğa ilişki
    }
}
