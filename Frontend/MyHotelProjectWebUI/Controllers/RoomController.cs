using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.Room;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RoomController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMes = await client.GetAsync("http://localhost:5226/api/Room");
            if (responseMes.IsSuccessStatusCode)
            {
                var jsondata = await responseMes.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<RoomListViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(AddRoomVieewModel arv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata=JsonConvert.SerializeObject(arv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMes = await client.PutAsync("http://localhost:5226/api/Room",sg);
            if (responseMes.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5226/api/Room/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateRoom(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responMessage = await client.GetAsync($"http://localhost:5226/api/Room/{id}");
            if (responMessage.IsSuccessStatusCode)
            {
                var jsondata = await responMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateRoomViewModel>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRoom(UpdateRoomViewModel urv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(urv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:5226/api/Room/", sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
