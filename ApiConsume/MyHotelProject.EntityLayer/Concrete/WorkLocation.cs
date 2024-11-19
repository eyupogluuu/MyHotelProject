using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class WorkLocation
    {
        public int workLocationID { get; set; }
        public string workLocationName { get; set; }
        public string workLocationCity { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
