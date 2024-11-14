using Microsoft.AspNetCore.Mvc;
using MyHotelProjectWebUI.Models.StuffViewModels;
using MyHotelProjectWebUI.Models.Testimonial;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace MyHotelProjectWebUI.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TestimonialController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responMesseage = await client.GetAsync("http://localhost:59549/api/Testimonial");
            if (responMesseage.IsSuccessStatusCode)
            {
                var jsondata = await responMesseage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TestimonialListViewModel>>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(AddTestimonialViewModel atv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(atv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:59549/api/Testimonial", sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:59549/api/Testimonial/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responMessage = await client.GetAsync($"http://localhost:59549/api/Testimonial/{id}");
            if (responMessage.IsSuccessStatusCode)
            {
                var jsondata = await responMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateTestimonialViewModel>(jsondata);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialViewModel utv)
        {
            var client = _httpClientFactory.CreateClient();
            var jsondata = JsonConvert.SerializeObject(utv);
            StringContent sg = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responMessage = await client.PutAsync("http://localhost:59549/api/Testimonial/", sg);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
