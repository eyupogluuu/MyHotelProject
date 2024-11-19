using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.EntityFramework;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            this.appUserDal = appUserDal;
        }

        public int TAppUserCount()
        {
            return appUserDal.AppUserCount();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetAll()
        {
            return appUserDal.GetAll();
        }

        public AppUser TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> TUsersListWithWorkLocations()
        {
            return appUserDal.UsersListWithWorkLocations();
        }
    }
}
