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

    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        
        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Delete(Room t)
        {
            _roomDal.Delete(t);
        }

        public Room GetByID(int id)
        {
            return _roomDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList();
        }

        public void Insert(Room t)
        {
            _roomDal.Insert(t);
        }

        public void Update(Room t)
        {
            _roomDal.Update(t);
        }

        public int TRoomCount()
        {
          return _roomDal.RoomCount();
        }
    }
}