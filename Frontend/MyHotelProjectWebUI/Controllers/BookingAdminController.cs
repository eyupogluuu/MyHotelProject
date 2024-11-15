using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Booking;
using Newtonsoft.Json;
using System.Net.Http;

namespace MyHotelProjectWebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responseMes = await client.GetAsync("http://localhost:59549/api/Booking");
            if (responseMes.IsSuccessStatusCode)
            {
                var jsondata = await responseMes.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ListBookingViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> ApprovedReservation2(int id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:59549/api/Booking/BookingAproved?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
