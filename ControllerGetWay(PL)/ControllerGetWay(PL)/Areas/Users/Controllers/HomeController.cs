using Microsoft.AspNetCore.Mvc;

namespace ControllerGetWay_PL_.Areas.Users.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
