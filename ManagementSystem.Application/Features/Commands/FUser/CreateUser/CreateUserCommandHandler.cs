
using ManagementSystem.Application.Repositories.Users;
using MediatR;

namespace ManagementSystem.Application.Features.Commands.FUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserWriteRepository _userWriteRepository;

        public CreateUserCommandHandler(IUserWriteRepository userWriteRepository)
        {
            _userWriteRepository = userWriteRepository;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _userWriteRepository.AddAsync(new()
            {
                Username = request.UserName,
                Email = request.UserEmail,
                PasswordHash = request.UserPassword,
                RoleId = request.RoleId

            });
            await _userWriteRepository.SaveAsync();

            return new();
        }
    }
}
