using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.UI.Controllers
{
    public class SigninController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
