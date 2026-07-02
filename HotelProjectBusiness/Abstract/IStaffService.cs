using HotelProjectEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusiness.Abstract
{
 public interface IStaffService:IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLastStaff();
    }
}
