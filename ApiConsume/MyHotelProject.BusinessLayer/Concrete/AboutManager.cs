using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        private readonly IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            aboutDal.Delete(t);
        }

        public List<About> TGetAll()
        {
            return aboutDal.GetAll();
        }

        public About TGetByID(int id)
        {
            return aboutDal.GetByID(id);
        }

        public void TInsert(About t)
        {
            aboutDal.Insert(t);
        }

        public void TUpdate(About t)
        {
            aboutDal.Update(t);
        }
    }
}
