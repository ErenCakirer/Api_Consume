using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccess.Abstract
{
  public interface IStaffDal:IGenericDal<Staff>
    {
        int GetStaffCount();
        List<Staff> LastStaff();
    }
}
