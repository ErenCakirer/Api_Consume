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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial t)
        {
_testimonialDal.Delete(t);
        }

        public Testimonial GetByID(int id)
        {
          return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
         return _testimonialDal.GetList();
        }

        public void Insert(Testimonial t)
        {
        _testimonialDal.Insert(t);
        }

        public void Update(Testimonial t)
        {
       _testimonialDal.Update(t);
        }
    }
}
