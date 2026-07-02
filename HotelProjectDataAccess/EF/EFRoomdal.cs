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
    public class EFRoomdal:GenericRepo<Room>,IRoomDal
    {
        public EFRoomdal(Context context):base(context) 
        {
            
        }

        public int RoomCount()
        {
     var context= new Context();
            var value= context.Rooms.Count();
            return value;
        }
    }
}
