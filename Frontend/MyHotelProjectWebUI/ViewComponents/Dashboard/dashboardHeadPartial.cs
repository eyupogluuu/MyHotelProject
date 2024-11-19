using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Dashboard
{
    public class dashboardHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
