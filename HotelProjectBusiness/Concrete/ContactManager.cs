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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact GetByID(int id)
        {
           return _contactDal.GetByID(id);
        }

        public int GetContactCount()
        {
       return  _contactDal.GetContactCount();
        }

        public void Insert(Contact t)
        {
          _contactDal.Insert(t);
        }

        public List<Contact> TGetList()
        {
        return _contactDal.GetList();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
