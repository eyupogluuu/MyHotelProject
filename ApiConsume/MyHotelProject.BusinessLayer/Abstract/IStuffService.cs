using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Abstract
{
    public interface IStuffService:IGenericService<Stuff>
    {
        int TGetStaffCount();
        List<Stuff> TLast4Staff();
    }
}
