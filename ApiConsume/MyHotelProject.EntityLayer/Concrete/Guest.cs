using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Guest
    {
        public int guestID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string city { get; set; }
    }
}
