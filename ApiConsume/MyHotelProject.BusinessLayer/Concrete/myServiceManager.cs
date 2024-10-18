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
    public class myServiceManager : ImyServiceService
    {
        private readonly ImyServiceDal serviceDal;

        public myServiceManager(ImyServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void TDelete(myService t)
        {
           serviceDal.Delete(t);
        }

        public List<myService> TGetAll()
        {
           return serviceDal.GetAll();
        }

        public myService TGetByID(int id)
        {
            return serviceDal.GetByID(id);
        }

        public void TInsert(myService t)
        {
           serviceDal.Insert(t);
        }

        public void TUpdate(myService t)
        {
           serviceDal.Update(t);
        }
    }
}
