using ManagementSystem.Application.DTOS;
using ManagementSystem.Application.Exceptions;
using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Application.Token;
using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Queries.FUser.LoginUser
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQueryRequest, LoginUserSuccessQueryResponse>
    {
        readonly UserManager<User> _userManager;
        readonly SignInManager<User> _signInMAnager;
        readonly ITokenHandler _tokenHandler;

        public LoginUserQueryHandler(
            UserManager<User> userManager,
            SignInManager<User> signInMAnager,
            ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signInMAnager = signInMAnager;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserSuccessQueryResponse> Handle(LoginUserQueryRequest request, CancellationToken cancellationToken)
        {
            User _user = await _userManager.FindByNameAsync(request.UserNameOrMail);
            if (_user == null)
                _user = await _userManager.FindByEmailAsync(request.UserNameOrMail);

            if (_user == null)
                return new LoginUserSuccessQueryResponse()
                {
                    Message = "Kayıt Bulunamadı",
                    Success = false
                };
            SignInResult result = await _signInMAnager.CheckPasswordSignInAsync(_user, request.UserPassword, false);

            if (result.Succeeded)
            {
                var userRoles = await _userManager.GetRolesAsync(_user);
                var authClaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub,_user.UserName!),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                };
                authClaims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

                DTOS.Token token = _tokenHandler.CreateAccessToken(5, authClaims);

                return new LoginUserSuccessQueryResponse()
                {
                    Message = "Giriş Başarılı",
                    Success = true,
                    Token = token
                };
            }


            //User _user = await _userManager.FindByNameAsync(request.UserNameOrMail);
            //if (_user == null)
            //    _user = await _userManager.FindByEmailAsync(request.UserNameOrMail);

            //if (_user == null)
            //    return new LoginUserErrorQueryResponse()
            //    {
            //        Message = "Kayıt Bulunamadı",
            //        Success = false
            //    };

            //SignInResult result = await _signInMAnager.CheckPasswordSignInAsync(_user, request.UserPassword, false);

            //if (result.Succeeded)
            //{
            //    DTOS.Token token = _tokenHandler.CreateAccessToken(5);

            //    return new LoginUserSuccessQueryResponse()
            //    {
            //        Message = "Giriş Başarılı",
            //        Success = true,
            //        Token = token
            //    };
            //}
            throw new AuthenticationErrorException();
        }
    }
}
