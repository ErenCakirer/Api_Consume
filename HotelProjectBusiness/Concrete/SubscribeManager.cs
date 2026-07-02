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
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        

        public void Delete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe GetByID(int id)
        {
           return _subscribeDal.GetByID(id);
        }

        public List<Subscribe> TGetList()
        {
          return _subscribeDal.GetList();
        }

        public void Insert(Subscribe t)
        {
          _subscribeDal.Insert(t);
        }

        public void Update(Subscribe t)
        {
    _subscribeDal.Update(t);
        }
    }
}
