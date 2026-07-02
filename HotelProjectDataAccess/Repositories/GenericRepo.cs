using HotelProjectDataAccess.Abstract;
using HotelProjectDataAccess.Concrete;
using Microsoft.EntityFrameworkCore; // 🎯 NOT: EntityState kullanabilmek için bu kütüphane eklendi!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccess.Repositories
{
    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepo(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            if (t == null) return;

            var entry = _context.Entry(t);
            if (entry.State == EntityState.Detached)
            {
                _context.Set<T>().Attach(t);
            }

            entry.State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}