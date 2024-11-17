using ManagementSystem.Domain.Common;
using MediatR;

namespace ManagementSystem.Application.Features.Commands.FUser.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string PhoneNumber { get; set; }

        public int RoleId { get; set; }
    }
}
