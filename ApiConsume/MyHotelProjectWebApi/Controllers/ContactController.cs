using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _contactService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(Contact b)
        {
            _contactService.TInsert(b);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var sil = _contactService.TGetByID(id);
            _contactService.TDelete(sil);
            return Ok();
        }

        [HttpPut("UpdateContact")]
        public IActionResult UpdateContact(Contact b)
        {
            _contactService.TUpdate(b);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
        
    }
}
