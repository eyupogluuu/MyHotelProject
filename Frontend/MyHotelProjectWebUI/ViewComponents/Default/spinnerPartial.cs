﻿using Microsoft.AspNetCore.Mvc;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class spinnerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
