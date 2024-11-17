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
    public class AppointmentWriteRepository : WriteRepository<Appointment>, IAppointmentWriteRepository
    {
        public AppointmentWriteRepository(ManagementSystemDbContext context) : base(context)
        {
        }
    }
}
