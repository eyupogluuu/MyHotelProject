using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService roomService;

        public RoomController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = roomService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room r)
        {
            roomService.TInsert(r);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var sil = roomService.TGetByID(id);
            roomService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room r)
        {
            roomService.TUpdate(r);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var value = roomService.TGetByID(id);
            return Ok(value);
        }
    }
}
