﻿using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class footerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
