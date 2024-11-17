using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Commands.FAppointments.CreateAppointments
{
    public class CreateAppointmentsCommandRequest : IRequest<CreateAppointmentsCommandResponse>
    {
        public string UserId { get; set; }
        public string AppointmentName { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
