using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public List<Testimonial> TGetAll()
        {
            return testimonialDal.GetAll();
        }

        public Testimonial TGetByID(int id)
        {
            return testimonialDal.GetByID(id);
        }

        public void TInsert(Testimonial t)
        {
             testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
