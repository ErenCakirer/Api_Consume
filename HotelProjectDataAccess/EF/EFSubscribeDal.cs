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
public class EFSubscribeDal:GenericRepo<Subscribe>,ISubscribeDal
    {
        public EFSubscribeDal(Context context):base(context) 
        {
            
        }
    }
}
