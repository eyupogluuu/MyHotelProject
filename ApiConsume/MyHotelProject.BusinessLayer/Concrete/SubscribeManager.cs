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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            this.subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe t)
        {
            subscribeDal.Delete(t);
        }

        public List<Subscribe> TGetAll()
        {
            return subscribeDal.GetAll();   
        }

        public Subscribe TGetByID(int id)
        {
            return subscribeDal.GetByID(id);
        }

        public void TInsert(Subscribe t)
        {
           subscribeDal.Insert(t);
        }

        public void TUpdate(Subscribe t)
        {
            subscribeDal.Update(t);
        }
    }
}
