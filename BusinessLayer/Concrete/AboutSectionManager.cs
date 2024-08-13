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
    public class AboutSectionManager : IAboutSectionService
    {
        private readonly IAboutSectionDal _aboutSectionDal;

        public AboutSectionManager(IAboutSectionDal aboutSectionDal)
        {
            _aboutSectionDal = aboutSectionDal;
        }

        public void Delete(AboutSection t)
        {
            _aboutSectionDal.Delete(t);
        }

        public AboutSection GetById(int id)
        {
            return _aboutSectionDal.GetById(id);
        }

        public List<AboutSection> GetListAll()
        {
            return _aboutSectionDal.GetListAll();
        }

        public void Insert(AboutSection t)
        {
            _aboutSectionDal.Insert(t);
        }

        public void Update(AboutSection t)
        {
            _aboutSectionDal.Update(t);
        }
    }
}
