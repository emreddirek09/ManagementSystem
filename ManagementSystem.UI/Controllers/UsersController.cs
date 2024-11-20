using ManagementSystem.Application.Features.Commands.FAppointments.CreateAppointments;
using ManagementSystem.Application.Features.Commands.FRole.CreateRole;
using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    [Authorize(Roles ="User")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<User> _userManager;
        public UsersController(IMediator mediator, UserManager<User> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var a = await _userManager.GetUserAsync(HttpContext.User);
            var b = await _userManager.GetRolesAsync(a);

            var userName = HttpContext.User.Identity.Name;
            var role = HttpContext.User.Claims.FirstOrDefault(a=>a.Type== "nebakiyonle")?.Value;

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
