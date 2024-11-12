using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuffController : ControllerBase
    {
        private readonly IStuffService stuffService;

        public StuffController(IStuffService stuffService)
        {
            this.stuffService = stuffService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = stuffService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStuff(Stuff s)
        {
            stuffService.TInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStuff(int id)
        {
            var sil = stuffService.TGetByID(id);
            stuffService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStuff(Stuff s)
        {
            stuffService.TUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStuff(int id)
        {
            var value=stuffService.TGetByID(id);
            return Ok(value);
        }
    }
}
