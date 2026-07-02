using HotelProjectBusiness.Abstract;
using HotelProjectDataAccess.Abstract;
using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusiness.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Delete(Booking t)
        {
          _bookingDal.Delete(t);
        }

        public Booking GetByID(int id)
        {
         return _bookingDal.GetByID(id);
        }

        public void Insert(Booking t)
        {
     _bookingDal.Insert(t);
        }

        public void TBookingStatusChangeCancel(int id)
        {
_bookingDal.BookingStatusChangeCancel(id);
        }

        public int TGetBookingCount()
        {
     return _bookingDal.GetBookingCount();
        }

        public List<Booking> TGetList()
        {
          return _bookingDal.GetList();
        }

        public List<Booking> TLastBookings()
        {
           return _bookingDal.LastBookings();
        }

        public void Update(Booking t)
        {
       _bookingDal.Update(t);
        }
    }
}
