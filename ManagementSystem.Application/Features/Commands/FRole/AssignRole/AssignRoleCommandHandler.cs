using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Application.Features.Commands.FRole.AssignRole
{
    public class AssignRoleCommandHandler : IRequestHandler<AssignRoleCommandRequest, AssignRoleCommandResponse>
    {
        private readonly UserManager<User> _userManager;

        public AssignRoleCommandHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AssignRoleCommandResponse> Handle(AssignRoleCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                User user = await _userManager.FindByNameAsync(request.UserName);
                if (user == null)
                    return new AssignRoleCommandResponse()
                    {
                        Success = false,
                        Message = "Kullanıcı Bulunamadı"
                    };
                 
                var result = await _userManager.AddToRoleAsync(user, request.RoleName);
                if (result.Succeeded)
                    return new AssignRoleCommandResponse()
                    {
                        Success = true,
                        Message = "Atama İşlemi Başarılı"
                    };
            }
            catch (Exception ex)
            {
                return new AssignRoleCommandResponse()
                {
                    Success = false,
                    Message = ex.InnerException.Message
                };
            }

            return new AssignRoleCommandResponse()
            {
                Success = false,
                Message = "Hata"
            };

        }
    }
}
