using Microsoft.EntityFrameworkCore;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Repositories;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.DataAccessLayer.EntityFramework
{
    public class EFAppUserDal:GenericRepository<AppUser>,IAppUserDal
    {
        public EFAppUserDal(MyHotelContext context) : base(context)
        {

        }
        public int AppUserCount()
        {
            var context = new MyHotelContext();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new MyHotelContext();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var context = new MyHotelContext();
            var values = context.Users.ToList();
            return values.ToList();
        }
    }
}
