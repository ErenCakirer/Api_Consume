using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccess.Abstract
{
   public interface IBookingDal:IGenericDal<Booking>
    {
        int GetBookingCount();
        List<Booking> LastBookings();
        void BookingStatusChangeCancel(int id);
    }
}
