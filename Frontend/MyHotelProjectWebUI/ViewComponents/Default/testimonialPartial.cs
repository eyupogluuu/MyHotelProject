using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Room;
using MyHotelProjectWebUI.Models.Testimonial;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class testimonialPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public testimonialPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/Testimonial");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
