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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Delete(Staff t)
        {
        _staffDal.Delete(t);
        }

        public Staff GetByID(int id)
        {
     return _staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
         return _staffDal.GetList();
        }

        public void Insert(Staff t)
        {
         _staffDal.Insert(t);
        }

        public void Update(Staff t)
        {
          _staffDal?.Update(t);
        }

        public int TGetStaffCount()
        {
        return _staffDal.GetStaffCount();
        }

        public List<Staff> TLastStaff()
        {
           return _staffDal.LastStaff();
        }
    }
}
