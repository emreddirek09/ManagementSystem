using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.GetAllUsers
{
    public class GetAllUsersQueryRequest:IRequest<GetAllUsersQueryResponse>
    {
    }
}
