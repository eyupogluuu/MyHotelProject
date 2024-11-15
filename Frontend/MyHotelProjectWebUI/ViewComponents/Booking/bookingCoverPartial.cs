using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Booking
{
    public class bookingCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
