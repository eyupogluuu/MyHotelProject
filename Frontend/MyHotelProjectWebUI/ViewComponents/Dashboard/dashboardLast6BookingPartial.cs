using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Booking;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Dashboard
{
    public class dashboardLast6BookingPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public dashboardLast6BookingPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/Booking/Last6Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last6BookingViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
