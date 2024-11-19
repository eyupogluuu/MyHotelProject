using Microsoft.AspNetCore.Mvc;
using MyHotelProject.BusinessLayer.Abstract;

namespace MyHotelProjectWebApi.Controllers
{
    public class DashboardWidgetsController : Controller
    {
        private readonly IStuffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;
        public DashboardWidgetsController(IStuffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
        }
        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }

        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }

        [HttpGet("AppUserCount")]
        public IActionResult AppUserCount()
        {
            var value = _appUserService.TAppUserCount();
            return Ok(value);
        }

        [HttpGet("RoomCount")]
        public IActionResult RoomCount()
        {
            var value = _roomService.TRoomCount();
            return Ok(value);
        }
    }
}
