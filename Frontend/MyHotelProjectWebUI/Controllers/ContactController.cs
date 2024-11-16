using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Contact;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {

            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(AddContactViewModel acv)
        {
            acv.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(acv);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:59549/api/Contact", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
