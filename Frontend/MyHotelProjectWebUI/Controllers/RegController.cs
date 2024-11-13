using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.EntityLayer.Concrete;
using MyHotelProjectWebUI.Models.AppUser;

namespace MyHotelProjectWebUI.Controllers
{
    public class RegController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public RegController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser()
            {
                name = user.name,
                surname = user.surname,
                UserName = user.username,
                Email = user.mail

            };
            var result = await userManager.CreateAsync(appUser, user.password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
