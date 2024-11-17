using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Commands.FRole.CreateRole
{
    public class CreateRoleCommandRequest:IRequest<CreateRoleCommandResponse>
    {
        public string RoleName { get; set; }
    }
}
