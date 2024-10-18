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
    public class StuffManager : IStuffService
    {
        private readonly IStuffDal stuffDal;

        public StuffManager(IStuffDal stuffDal)
        {
            this.stuffDal = stuffDal;
        }

        public void TDelete(Stuff t)
        {
            stuffDal.Delete(t);
        }

        public List<Stuff> TGetAll()
        {
          return stuffDal.GetAll();
        }

        public Stuff TGetByID(int id)
        {
            return stuffDal.GetByID(id);
        }

        public void TInsert(Stuff t)
        {
            stuffDal.Insert(t);
        }

        public void TUpdate(Stuff t)
        {
            stuffDal.Update(t);
        }
    }
}
