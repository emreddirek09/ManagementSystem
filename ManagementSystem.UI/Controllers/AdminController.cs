using ManagementSystem.Application.Features.Commands.FRole.AssignRole;
using ManagementSystem.Application.Features.Commands.FRole.CreateRole;
using ManagementSystem.Application.Features.Queries.FUser.GetAllUsers;
using ManagementSystem.Application.Features.Queries.FUser.LoginUser;
using ManagementSystem.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole([FromBody] CreateRoleCommandRequest model)
        {
            if (ModelState.IsValid)
            {

                CreateRoleCommandResponse res = await _mediator.Send(model);

                return Json(new { success = res.Success, message = res.Message });
            }

            return Json(new { success = false, message = "Geçersiz Kayıt!" });
        }

        [HttpGet]
        public async Task<IActionResult> AssignRole()
        {
            GetAllUsersQueryResponse response = await _mediator.Send(new GetAllUsersQueryRequest());

            

            ViewData["Users"] = response;
            return View(Json(new { success = false, message = "Buraya geldim", data =" response.Data" }));

        }

        [HttpPost]
        public async Task<IActionResult> AssignRole([FromBody] AssignRoleCommandRequest model)
        {
            if (ModelState.IsValid)
            {

                AssignRoleCommandResponse res = await _mediator.Send(model);

                return Json(new { success = res.Success, message = res.Message });
            }

            return Json(new { success = false, message = "Geçersiz Kayıt!" });
        }
    }
}
