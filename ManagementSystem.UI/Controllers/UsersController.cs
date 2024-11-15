using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
