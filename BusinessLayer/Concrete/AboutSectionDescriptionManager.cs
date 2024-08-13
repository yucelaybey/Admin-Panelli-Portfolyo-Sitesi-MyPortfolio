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
    public class AboutSectionDescriptionManager : IAboutSectionDescriptionService
    {
        private readonly IAboutSectionDescriptionDal _aboutSectionDescriptionDal;

        public AboutSectionDescriptionManager(IAboutSectionDescriptionDal aboutSectionDescriptionDal)
        {
            _aboutSectionDescriptionDal = aboutSectionDescriptionDal;
        }

        public void Delete(AboutSectionDescription t)
        {
            _aboutSectionDescriptionDal.Delete(t);
        }

        public AboutSectionDescription GetById(int id)
        {
            return _aboutSectionDescriptionDal.GetById(id);
        }

        public List<AboutSectionDescription> GetListAll()
        {
            return _aboutSectionDescriptionDal.GetListAll();
        }

        public void Insert(AboutSectionDescription t)
        {
            _aboutSectionDescriptionDal.Insert(t);
        }

        public void Update(AboutSectionDescription t)
        {
            _aboutSectionDescriptionDal.Update(t);
        }
    }
}
