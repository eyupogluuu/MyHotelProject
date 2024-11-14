using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Room;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class roomPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public roomPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<RoomListViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
