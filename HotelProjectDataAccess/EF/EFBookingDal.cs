using HotelProjectDataAccess.Abstract;
using HotelProjectDataAccess.Concrete;
using HotelProjectDataAccess.Repositories;
using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccess.EF
{
  public class EFBookingDal : GenericRepo<Booking>, IBookingDal
    {
        public EFBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusChangeCancel(int id)
        {
var context=new Context();
            var values=context.Bookings.Find(id);
            if (values != null)
            {
                values.Status = "İptal Edildi";
                context.SaveChanges();
            }
        }

        public int GetBookingCount()
        {
 var context=new  Context(); 
            var value=context.Bookings.Count();
            return value;
        }

        public List<Booking> LastBookings()
        {
           var context= new Context();
            var values=context.Bookings.OrderByDescending(x=>x.BookingID).Take(6).ToList();
            return values;
        }
    }
}
