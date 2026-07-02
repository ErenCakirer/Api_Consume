using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusiness.Abstract
{
   public interface IBookingService:IGenericService<Booking>
    {
        int TGetBookingCount();
        List<Booking> TLastBookings();
       void TBookingStatusChangeCancel(int id);
    }
}
