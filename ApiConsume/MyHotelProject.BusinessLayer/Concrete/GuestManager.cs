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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            this.guestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
            guestDal.Delete(t);
        }

        public List<Guest> TGetAll()
        {
            return guestDal.GetAll();
        }

        public Guest TGetByID(int id)
        {
            return (guestDal.GetByID(id));  
        }

        public void TInsert(Guest t)
        {
            guestDal.Insert(t);
        }

        public void TUpdate(Guest t)
        {
           guestDal.Update(t);
        }
    }
}
