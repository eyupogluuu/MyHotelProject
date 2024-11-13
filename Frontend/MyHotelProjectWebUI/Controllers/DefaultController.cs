using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
