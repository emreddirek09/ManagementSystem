using ManagementSystem.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Domain
{
    public class UserRole: IdentityRole<string>
    {   

        public ICollection<User> Users { get; set; } // User ile bire-çoğa ilişki
    }
}
