using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProjectWebUI.Models.AppUser;

namespace MyHotelProjectWebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserViewModel loginUser)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginUser.username, loginUser.password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "myService");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
