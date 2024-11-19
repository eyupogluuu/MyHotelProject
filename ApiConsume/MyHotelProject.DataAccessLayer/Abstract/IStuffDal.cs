using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.Abstract
{
    public interface IStuffDal:IGenericDal<Stuff>
    {
        int GetStaffCount();
        List<Stuff> Last4Staff();
    }
}
