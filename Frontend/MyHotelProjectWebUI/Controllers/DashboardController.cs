using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
