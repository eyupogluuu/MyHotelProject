using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService guestService;

        public GuestController(IGuestService guestService)
        {
            this.guestService = guestService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = guestService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest r)
        {
            guestService.TInsert(r);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var sil = guestService.TGetByID(id);
            guestService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest r)
        {
            guestService.TUpdate(r);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var value = guestService.TGetByID(id);
            return Ok(value);
        }
    }
}
