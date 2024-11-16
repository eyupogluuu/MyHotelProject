using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Contact
    {
        public int contactID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string subject { get; set; }
        public string ConMessage { get; set; }
        public DateTime Date { get; set; }
    }
}
