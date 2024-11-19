using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        void TBookingStatusChangeApproved(Booking booking);
        int TGetBookingCount();
        List<Booking> TLast6Bookings();
    }
}
