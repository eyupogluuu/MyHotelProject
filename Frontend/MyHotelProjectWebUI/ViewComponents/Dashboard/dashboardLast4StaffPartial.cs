using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.StuffViewModels;
using Newtonsoft.Json;

namespace MyHotelProjectWebUI.ViewComponents.Dashboard
{
    public class dashboardLast4StaffPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public dashboardLast4StaffPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:59549/api/Staff/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4StuffViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
