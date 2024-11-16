using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser
{
    public class GetByEmailUserQueryRequest : IRequest<GetByEmailUserQueryResponse>
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }

    }
}
