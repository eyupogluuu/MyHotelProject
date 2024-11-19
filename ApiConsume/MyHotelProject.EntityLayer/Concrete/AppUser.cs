using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyHotelProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string? city { get; set; }
        public string? imagUrl { get; set; }
        public string? country { get; set; }
        public string? gender { get; set; }
        public string? workDepartment { get; set; }
        public int workLocationID { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
