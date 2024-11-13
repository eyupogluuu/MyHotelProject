using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class sliderPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
