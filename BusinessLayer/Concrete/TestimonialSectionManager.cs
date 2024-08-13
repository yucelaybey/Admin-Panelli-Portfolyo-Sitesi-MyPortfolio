using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialSectionManager : ITestimonialSectionService
    {
        private readonly ITestimonialSectionDal _testimonialSectionDal;

        public TestimonialSectionManager(ITestimonialSectionDal testimonialSectionDal)
        {
            _testimonialSectionDal = testimonialSectionDal;
        }

        public void Delete(TestimonialSection t)
        {
            _testimonialSectionDal.Delete(t);
        }

        public TestimonialSection GetById(int id)
        {
            return _testimonialSectionDal.GetById(id);
        }

        public List<TestimonialSection> GetListAll()
        {
            return _testimonialSectionDal.GetListAll();
        }

        public void Insert(TestimonialSection t)
        {
            _testimonialSectionDal.Insert(t);
        }

        public void Update(TestimonialSection t)
        {
            _testimonialSectionDal.Update(t);
        }
    }
}
