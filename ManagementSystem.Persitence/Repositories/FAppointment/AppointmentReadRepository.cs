using ManagementSystem.Application.Repositories.Appointments;
using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using ManagementSystem.Persitence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Persitence.Repositories.FAppointment
{
    public class AppointmentReadRepository : ReadRepository<Appointment>, IAppointmentReadRepository
    {
        public AppointmentReadRepository(ManagementSystemDbContext context) : base(context)
        {
        }
    }
}
