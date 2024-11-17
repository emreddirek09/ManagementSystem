using ManagementSystem.Application.Features.Commands.FAppointments.CreateAppointments;
using ManagementSystem.Application.Features.Commands.FRole.CreateRole;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    //[Authorize(Policy = "UserPolicy")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
         

        [HttpPost]
        public async Task<IActionResult> CreateAppointments([FromBody] CreateAppointmentsCommandRequest model)
        {
            if (ModelState.IsValid)
            {

                CreateAppointmentsCommandResponse res = await _mediator.Send(model);

                return Json(new { success = res.Success, message = res.Message });
            }

            return Json(new { success = false, message = "Geçersiz Kayıt!" });
        }
    }
}
