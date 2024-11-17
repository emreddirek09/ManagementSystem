using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Commands.FRole.AssignRole
{
    public class AssignRoleCommandRequest:IRequest<AssignRoleCommandResponse>
    {
        public string UserName { get; set; }
        //public string RoleName { get; set; }

    }
}
