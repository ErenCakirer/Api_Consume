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
    public class EFTestimonial:GenericRepo<Testimonial>,ITestimonialDal
    {
        public EFTestimonial(Context context):base(context)
        {
            
        }
    }
}
