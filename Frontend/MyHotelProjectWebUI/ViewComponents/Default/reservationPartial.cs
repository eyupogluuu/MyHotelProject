using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class reservationPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
