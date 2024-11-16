using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
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
        readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInMAnager;

        readonly IUserReadRepository _userReadRepository;

        public LoginUserQueryHandler(UserManager<User> userManager, SignInManager<User> signInMAnager, IUserReadRepository userReadRepository)
        {
            _userManager = userManager;
            _signInMAnager = signInMAnager;
            _userReadRepository = userReadRepository;
        }

        public async Task<LoginUserQueryResponse> Handle(LoginUserQueryRequest request, CancellationToken cancellationToken)
        {
            User _user = await _userManager.FindByNameAsync(request.UserNameOrMail);
            if (_user == null)
                _user = await _userManager.FindByEmailAsync(request.UserNameOrMail);

            if (_user == null)
                return new LoginUserQueryResponse()
                {
                    Message = "Kayıt Bulunamadı",
                    Success = false,
                    Data = _user
                };

            SignInResult result = await _signInMAnager.CheckPasswordSignInAsync(_user, request.UserPassword, false);

            if (result.Succeeded)
                return new LoginUserQueryResponse()
                {
                    Message = "Giriş Başarılı",
                    Success = true,
                    Data = ""

                };
            return new LoginUserQueryResponse()
            {
                Message = "Kayıt Bulunamadı",
                Success = false,
                Data = _user
            };
        }
    }
}
