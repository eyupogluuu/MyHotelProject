using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Dashboard
{
    public class dashboardSubscribeCountPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
