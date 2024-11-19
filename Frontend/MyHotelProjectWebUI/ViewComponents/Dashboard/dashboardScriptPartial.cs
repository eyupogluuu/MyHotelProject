using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Dashboard
{
    public class dashboardScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
