using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.StuffViewModels;
using Newtonsoft.Json;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class StuffController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public StuffController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = httpClientFactory.CreateClient();
            var responMessage = await client.GetAsync("http://localhost:5226/api/Stuff");
            if (responMessage.IsSuccessStatusCode)
            {
                var jsondata = await responMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<StuffListViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddStuff()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStuff(AddStuffViewModel asv)
        {
            var client = httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(asv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:5226/api/Stuff", sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteStuff(int id)
        {
            var client = httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5226/api/Stuff?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateStuff(int id)
        {
            var client = httpClientFactory.CreateClient();
            var responMessage = await client.GetAsync($"http://localhost:5226/api/Stuff/{id}");
            if (responMessage.IsSuccessStatusCode)
            {
                var jsondata = await responMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateStuffViewModel>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateStuff(UpdateStuffViewModel usv)
        {
            var client = httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(usv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:5226/api/Stuff/",sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
