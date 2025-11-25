using Business_Layer_BL_.DTOS.Combine_DTOS.F_User_UserCredsDTOS;
using Business_Layer_BL_.Services.F_UserCredsServices.Interfaces;
using Business_Layer_BL_.Services.F_UserServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControllerGetWay_PL_.Areas.Users.Controllers
{
    [Area("Users")]
    public class UserAccountController : Controller
    {
        private readonly IUserCredsService _userCredsService;
        private readonly IUserServices _userServices;

        public UserAccountController(IUserServices userServices, IUserCredsService userCredsService)
        {
            _userCredsService = userCredsService;
            _userServices = userServices;
        }
        public IActionResult SignUpView()
        {
            return View();
        }
        [HttpPost]
        [Route("Users/[UserAccount]/[UserRegistration]")]
        public IActionResult UserRegistration(UserAndUserCredsDTOS userAndUserCredsDTOS)
        {

            var UserResponse = _userServices.InsertUser(userAndUserCredsDTOS.InsertUserDTO!);
            var UserCredsResponse = _userCredsService.InsertUserCreds(userAndUserCredsDTOS.insertUserCredsDTO!);

            return RedirectToAction("Index", "Home");
        }
    }
}
