using Microsoft.AspNetCore.Mvc;

namespace asp.netCoreWebAppFirstApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
