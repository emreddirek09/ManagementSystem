
using ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser;
using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ManagementSystem.Application.Features.Commands.FUser.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserWriteRepository _userWriteRepository;
        readonly UserManager<User> _userManager;
        readonly private IMediator _mediator;

        public CreateUserCommandHandler(IUserWriteRepository userWriteRepository, UserManager<User> userManager, IMediator mediator)
        {
            _userWriteRepository = userWriteRepository;
            _userManager = userManager;
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

            try
            {
                IdentityResult result = await _userManager.CreateAsync(new()
                {
                    Id = Guid.NewGuid(),
                    UserName = request.UserName,
                    Email = request.UserEmail,

                }, request.UserPassword);

                if (result.Succeeded)
                    return new CreateUserCommandResponse
                    {
                        Success = true,
                        Message = "Kullanıcı başarıyla oluşturuldu!"
                    };
            }
            catch (Exception ex)
            {

                throw;
            }

            //await _userWriteRepository.AddAsync(new()
            //{
            //    UserName = request.UserName,
            //    Email = request.UserEmail,
            //    PasswordHash = request.UserPassword

            //});
            // await _userWriteRepository.SaveAsync();



            return new CreateUserCommandResponse
            {
                Success = false,
                Message = "Hata"
            };
        }
    }
}
