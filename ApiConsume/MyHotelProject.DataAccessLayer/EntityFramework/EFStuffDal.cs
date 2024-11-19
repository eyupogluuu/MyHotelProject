using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.EntityFramework
{
    public class EFStuffDal : GenericRepository<Stuff>, IStuffDal
    {
        public EFStuffDal(MyHotelContext context) : base(context)
        {

        }
        public int GetStaffCount()
        {
            using var context = new MyHotelContext();
            var value = context.Stuffs.Count();
            return value;
        }

        public List<Stuff> Last4Staff()
        {
            using var context = new MyHotelContext();
            var values = context.Stuffs.OrderByDescending(x => x.stuffId).Take(4).ToList();
            return values;
        }


    }
}
