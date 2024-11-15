using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Booking;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(AddBookingViewModel abm)
        {
            abm.status = "Onay Bekliyor";
            abm.description=string .Empty;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(abm);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:59549/api/Booking", stringContent);
            return RedirectToAction("Index", "Default");
        }
    }
}
