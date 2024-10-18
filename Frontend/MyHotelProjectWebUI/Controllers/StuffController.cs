using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.Controllers
{
    public class StuffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
