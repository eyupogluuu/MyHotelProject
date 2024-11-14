using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.myService;
using MyHotelProjectWebUI.Models.Room;
using Newtonsoft.Json;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class myServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public myServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMes = await client.GetAsync("http://localhost:59549/api/myService");
            if (responseMes.IsSuccessStatusCode)
            {
                var jsondata = await responseMes.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ListmyServiceViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddmyService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddmyService(AddmyServiceViewModel amsv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(amsv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMes = await client.PutAsync("http://localhost:59549/api/myService", sg);
            if (responseMes.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeletemyService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:59549/api/myService/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdatemyService(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responMessage = await client.GetAsync($"http://localhost:59549/api/myService/{id}");
            if (responMessage.IsSuccessStatusCode)
            {
                var jsondata = await responMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdatemyServiceViewModel>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatemyService(UpdatemyServiceViewModel umsv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(umsv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:59549/api/myService/", sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
