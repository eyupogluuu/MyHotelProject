using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            this.subscribeService = subscribeService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var values = subscribeService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe s)
        {
            subscribeService.TInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var sil = subscribeService.TGetByID(id);
            subscribeService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe s)
        {
            subscribeService.TUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var value = subscribeService.TGetByID(id);
            return Ok(value);
        }
    }
}
