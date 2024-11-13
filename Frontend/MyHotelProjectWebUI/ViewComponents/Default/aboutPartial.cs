using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.About;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class aboutPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public aboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IViewComponentResult> Invoke()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5226/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AboutListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
