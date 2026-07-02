using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusiness.Abstract
{
    public interface IGenericService< T>where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> TGetList();
        T GetByID(int id);
    }
}
