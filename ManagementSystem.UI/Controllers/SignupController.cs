using ManagementSystem.Application.Features.Commands.FUser.CreateUser;
using ManagementSystem.Application.Features.Queries.FUser.GetByEmailUser;
 using MediatR;
using Microsoft.AspNetCore.Mvc; 

namespace ManagementSystem.UI.Controllers
{
    public class SignupController : Controller
    {
        readonly private IMediator _mediator;

        public SignupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> üyeOl([FromBody] CreateUserCommandRequest model)
        {
            if (ModelState.IsValid)
            {
                CreateUserCommandResponse res = await _mediator.Send(model);

                return Json(new { success = res.Success, message = res .Message});
            }

            return Json(new { success = false, message = "Geçersiz giriş!" });
        }




    }
}
