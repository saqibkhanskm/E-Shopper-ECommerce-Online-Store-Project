using Microsoft.AspNetCore.Mvc;

namespace ControllerGetWay_PL_.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserAccountController : Controller
    {
        public IActionResult SignUpView()
        {
            return View();
        }
    }
}
