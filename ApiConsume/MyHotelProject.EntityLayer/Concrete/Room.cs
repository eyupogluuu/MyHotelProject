using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Room
    {
        public int roomId { get; set; }
        public string roomNumber { get; set; }
        public string tittle { get; set; }
        public int price { get; set; }
        public string bedCount { get; set; }
        public string bathCount { get; set; }
        public string wifi { get; set; }
        public string descreption { get; set; }
    }
}
