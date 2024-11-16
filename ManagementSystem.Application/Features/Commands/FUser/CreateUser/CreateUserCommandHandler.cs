
using ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser;
using ManagementSystem.Application.Repositories.Users; 
using MediatR;

namespace ManagementSystem.Application.Features.Commands.FUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserWriteRepository _userWriteRepository;
         readonly private IMediator _mediator;

        public CreateUserCommandHandler(IUserWriteRepository userWriteRepository, IMediator mediator)
        {
            _userWriteRepository = userWriteRepository;
            _mediator = mediator;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            GetByEmailUserQueryRequest getByEmail = new GetByEmailUserQueryRequest() { UserEmail = request.UserEmail, UserName = request.UserName };
            GetByEmailUserQueryResponse getByEmailUser = await _mediator.Send(getByEmail);
            if (getByEmailUser.Data is not null)
                return new CreateUserCommandResponse
                {
                    Success = false,
                    Message = "Eski kayıt girişi!"
                };
             
            
            await _userWriteRepository.AddAsync(new()
            {
                UserName = request.UserName,
                Email = request.UserEmail,
                PasswordHash = request.UserPassword

            });
            await _userWriteRepository.SaveAsync();

            return new CreateUserCommandResponse
            {
                Success = true,
                Message = "Kullanıcı başarıyla oluşturuldu!"
            };
        }
    }
}
