using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;
        public AboutController(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(About r)
        {
            aboutService.TInsert(r);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var sil = aboutService.TGetByID(id);
            aboutService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About r)
        {
            aboutService.TUpdate(r);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = aboutService.TGetByID(id);
            return Ok(value);
        }
    }
}
