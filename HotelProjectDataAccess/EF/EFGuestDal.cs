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
    public class EFGuestDal : GenericRepo<Guest>, IGuestDal
    {
        public EFGuestDal(Context context) : base(context)
        {
        }

        public int GuestCount()
        {
          var  context= new Context();
            var value=context.Users.Count();
            return value;
        }
    }
    
    }

