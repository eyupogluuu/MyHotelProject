using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class scriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
