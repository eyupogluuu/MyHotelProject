using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var values = testimonialService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial t)
        {
            testimonialService.TInsert(t);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var sil = testimonialService.TGetByID(id);
            testimonialService.TDelete(sil);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial t)
        {
            testimonialService.TUpdate(t);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = testimonialService.TGetByID(id);
            return Ok(value);
        }
    }
}
