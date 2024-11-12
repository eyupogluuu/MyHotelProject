using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class myServiceController : ControllerBase
    {
        private readonly ImyServiceService myServiceService;

        public myServiceController(ImyServiceService myServiceService)
        {
            this.myServiceService = myServiceService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = myServiceService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddmyService(myService s)
        {
            myServiceService.TInsert(s);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletemyService(int id)
        {
            var sil = myServiceService.TGetByID(id);
            myServiceService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatemyService(myService s)
        {
            myServiceService.TUpdate(s);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetmyService(int id)
        {
            var value = myServiceService.TGetByID(id);
            return Ok(value);
        }
    }
}
