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
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void Delete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service GetByID(int id)
        {
  return _servicesDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
          return _servicesDal.GetList();
        }

        public void Insert(Service t)
        {
           _servicesDal.Insert(t);
        }

        public void Update(Service t)
        {
          _servicesDal.Update(t);
        }
    }
}
