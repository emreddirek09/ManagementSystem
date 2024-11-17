 
using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Domain
{
    public class User : IdentityUser<Guid>

    {
        public Guid Id { get; set; }
        public ICollection<Appointment> Appointments { get; set; } // User ile Appointment arasında bire-çoğa ilişki
    }
}
