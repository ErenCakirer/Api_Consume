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
    public class EFStaffDal:GenericRepo<Staff>,IStaffDal
    {
        public EFStaffDal(Context context):base(context)
        {
            
        }

        public int GetStaffCount()
        {
          using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> LastStaff()
        {
            using var context = new Context();
            var values=context.Staffs.OrderByDescending (x => x.StaffID).Take(4).ToList();
            return values;
        }
    }
}
