using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class UsersController : Controller
    {
        [Authorize(AuthenticationSchemes = "User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
