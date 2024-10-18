using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int testimonialId { get; set; }
        public string nameSurname { get; set; }
        public string tittle { get; set; }
        public string comment { get; set; }
        public string imageUrl { get; set; }
        
    }
}
