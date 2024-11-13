using MyHotelProject.BusinessLayer.Abstract;
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
        private readonly IAboutService aboutDal;

        public AboutManager(IAboutService aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void TDelete(About t)
        {
            aboutDal.TDelete(t);
        }

        public List<About> TGetAll()
        {
            return aboutDal.TGetAll();
        }

        public About TGetByID(int id)
        {
            return aboutDal.TGetByID(id);
        }

        public void TInsert(About t)
        {
            aboutDal.TInsert(t);
        }

        public void TUpdate(About t)
        {
            aboutDal.TUpdate(t);
        }
    }
}
