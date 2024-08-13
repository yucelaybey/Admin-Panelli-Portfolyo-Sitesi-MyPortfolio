using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaSectionManager : ISocialMediaSectionService
    {
        private readonly ISocialMediaSectionDal _socialMediaSectionDal;

        public SocialMediaSectionManager(ISocialMediaSectionDal socialMediaSectionDal)
        {
            _socialMediaSectionDal = socialMediaSectionDal;
        }

        public void Delete(SocialMediaSection t)
        {
            _socialMediaSectionDal.Delete(t);
        }

        public SocialMediaSection GetById(int id)
        {
            return _socialMediaSectionDal.GetById(id);
        }

        public List<SocialMediaSection> GetListAll()
        {
            return _socialMediaSectionDal.GetListAll();
        }

        public void Insert(SocialMediaSection t)
        {
            _socialMediaSectionDal.Insert(t);
        }

        public void Update(SocialMediaSection t)
        {
            _socialMediaSectionDal.Update(t);
        }
    }
}
