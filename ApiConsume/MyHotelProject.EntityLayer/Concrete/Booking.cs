using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Booking
    {
        public int bookingID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkOut { get; set; }
        public string adultCount { get; set; }
        public string childCount { get; set; }
        public string roomCount { get; set; }
        public string specialRequest { get; set; }
        public string? description { get; set; }
        public string status { get; set; }
        public string? city { get; set; }
        public string? country { get; set; }
    }
}
