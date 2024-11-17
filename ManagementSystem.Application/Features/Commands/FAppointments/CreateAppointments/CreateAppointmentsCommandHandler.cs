using ManagementSystem.Application.Features.Commands.FUser.CreateUser;
using ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser;
using ManagementSystem.Application.Repositories.Appointments;
using MediatR;

namespace ManagementSystem.Application.Features.Commands.FAppointments.CreateAppointments
{
    public class CreateAppointmentsCommandHandler : IRequestHandler<CreateAppointmentsCommandRequest, CreateAppointmentsCommandResponse>
    {
        readonly private IMediator _mediator;
        readonly IAppointmentWriteRepository _writeRepository;

        public CreateAppointmentsCommandHandler(IMediator mediator, IAppointmentWriteRepository writeRepository)
        {
            _mediator = mediator;
            _writeRepository = writeRepository;
        }

        public async Task<CreateAppointmentsCommandResponse> Handle(CreateAppointmentsCommandRequest request, CancellationToken cancellationToken)
        {
            bool res = await _writeRepository.AddAsync(new Domain.Appointment()
            {
                UserId = Guid.Parse(request.UserId),
                AppointmentDate = request.AppointmentDate,
                AppointmentName = request.AppointmentName

            });

            await _writeRepository.SaveAsync();


            return new CreateAppointmentsCommandResponse
            {
                Success = true,
                Message = "Randevu Oluşturuldu"
            };
        }
    }
}
