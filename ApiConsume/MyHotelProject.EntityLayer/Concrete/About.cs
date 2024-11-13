using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class About
    {
        public int aboutId { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string content { get; set; }
        public int roomCount { get; set; }
        public int staffCount { get; set; }
        public int customerCount { get; set; }
    }
}
