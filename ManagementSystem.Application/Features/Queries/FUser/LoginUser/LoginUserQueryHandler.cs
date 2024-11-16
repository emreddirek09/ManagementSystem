using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using MediatR;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.LoginUser
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQueryRequest, LoginUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepository;

        public LoginUserQueryHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public async Task<LoginUserQueryResponse> Handle(LoginUserQueryRequest request, CancellationToken cancellationToken)
        {
            User user = await _userReadRepository.GetSingleAsync(x => x.UserName == request.UserName || x.Email == request.UserName && x.PasswordHash == request.UserPassword, false);
            if (user is not null)
                return new LoginUserQueryResponse()
                {
                    Message = "Kayıt Bulunamadı",
                    Success = false,
                    Data = user

                };

            return new LoginUserQueryResponse()
            {
                Message = "Giriş Başarılı",
                Success = true,
                Data = user

            };
        }
    }
}
