using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    [Authorize(Roles = "User")]
    public class UsersController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }
    }
}
