using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.Controllers
{
    public class adminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult headPartial()
        {
            return PartialView();
        }
        public PartialViewResult headerPartial()
        {
            return PartialView();
        }
        public PartialViewResult preloaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult navheaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult sidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult scriptPartial()
        {
            return PartialView();
        }
        public PartialViewResult footerPartial()
        {
            return PartialView();
        }
    }
}
