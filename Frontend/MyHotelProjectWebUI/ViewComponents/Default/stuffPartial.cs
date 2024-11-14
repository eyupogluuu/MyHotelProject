using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Room;
using MyHotelProjectWebUI.Models.StuffViewModels;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class stuffPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public stuffPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/Stuff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StuffListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
