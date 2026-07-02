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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            this.guestDal = guestDal;
        }

        public void Delete(Guest t)
        {
   guestDal.Delete(t);
        }

        public Guest GetByID(int id)
        {
          return guestDal.GetByID(id);
        }

        public void Insert(Guest t)
        {
            guestDal.Insert(t);
        }

        public List<Guest> TGetList()
        {
            return guestDal.GetList();
        }

        public int TGuestCount()
        {
           return  guestDal.GuestCount();
        }

        public void Update(Guest t)
        {
     guestDal.Update(t);
        }
    }
}
