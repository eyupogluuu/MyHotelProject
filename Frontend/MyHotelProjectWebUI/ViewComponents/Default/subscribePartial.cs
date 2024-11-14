using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class subscribePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
