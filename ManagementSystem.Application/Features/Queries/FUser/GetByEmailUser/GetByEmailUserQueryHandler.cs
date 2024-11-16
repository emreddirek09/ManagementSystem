using ManagementSystem.Application.Repositories.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser
{
    public class GetByEmailUserQueryHandler : IRequestHandler<GetByEmailUserQueryRequest, GetByEmailUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepository;

        public GetByEmailUserQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public async Task<GetByEmailUserQueryResponse> Handle(GetByEmailUserQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _userReadRepository.GetSingleAsync(x => x.UserName == request.UserName || x.Email == request.UserEmail, false);

            return new()
            {
                Data = user

            };
        }
    }
}
