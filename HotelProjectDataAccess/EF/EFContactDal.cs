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
public class EFContactDal:GenericRepo<Contact>,IContactDal
    {
        public EFContactDal(Context context):base(context) { }

        public int GetContactCount()
        {
         var context= new Context();
            return context.Contacts.Count();
        
        }
    }
}
