using ManagementSystem.Application.Features.Commands.FUser.CreateUser;
using ManagementSystem.Application.Features.Queries.FUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class SigninController : Controller
    {
        readonly private IMediator _mediator;

        public SigninController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> _GirisYap([FromBody] LoginUserQueryRequest model)
        {
            if (ModelState.IsValid)
            {

                LoginUserQueryResponse res = await _mediator.Send(model);

                return Json(new { success = res.Success, message = res.Message });
            }

            return Json(new { success = false, message = "Geçersiz giriş!" });
        }

    }
}
