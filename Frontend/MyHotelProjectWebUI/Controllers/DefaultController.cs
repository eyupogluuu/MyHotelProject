using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Subscribe;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
