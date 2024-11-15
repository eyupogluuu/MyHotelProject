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
    public class BookingManager : IBookingService
    {
        private IBookingDal bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            this.bookingDal = bookingDal;
        }

        public void TBookingStatusChangeApproved(Booking booking)
        {
            bookingDal.BookingStatusChangeApproved(booking);
        }

        public void TDelete(Booking t)
        {
            bookingDal.Delete(t);
        }

        public List<Booking> TGetAll()
        {
            return bookingDal.GetAll();
        }

        public Booking TGetByID(int id)
        {
            return bookingDal.GetByID(id);
        }

        public void TInsert(Booking t)
        {
            bookingDal.Insert(t);
        }

        public void TUpdate(Booking t)
        {
            bookingDal.Update(t);
        }
    }
}
