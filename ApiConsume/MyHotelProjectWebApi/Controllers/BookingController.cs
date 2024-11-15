using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;

namespace MyHotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService bookingService;

        public BookingController(IBookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = bookingService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking b)
        {
            bookingService.TInsert(b);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var sil = bookingService.TGetByID(id);
            bookingService.TDelete(sil);
            return Ok();
        }

        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking b)
        {
            bookingService.TUpdate(b);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = bookingService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut("aaaa")]
        public IActionResult aaaa(Booking booking)
        {
            bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
    }
}
