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
    public class EFBookingDal:GenericRepository<Booking>,IBookingDal
    {
        public EFBookingDal(MyHotelContext context) : base(context)
        {

        }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new MyHotelContext();
            var values = context.Bookings.Where(x => x.bookingID == booking.bookingID).FirstOrDefault();
            values.status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
