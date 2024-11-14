using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.About;
using MyHotelProjectWebUI.Models.myService;
using Newtonsoft.Json;
using System.Net.Http;

namespace MyHotelProjectWebUI.ViewComponents.Default
{
    public class myServicePartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public myServicePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/myService");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ListmyServiceViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
