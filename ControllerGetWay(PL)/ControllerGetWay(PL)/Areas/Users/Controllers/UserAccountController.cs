using Microsoft.AspNetCore.Mvc;

namespace ControllerGetWay_PL_.Areas.Users.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult SignUpView()
        {
            return View();
        }
    }
}
