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
    public class ShowcaseExperienceManager : IShowcaseExperienceService
    {
        private readonly IShowcaseExperienceDal _showcaseExperienceDal;

        public ShowcaseExperienceManager(IShowcaseExperienceDal showcaseExperienceDal)
        {
            _showcaseExperienceDal = showcaseExperienceDal;
        }

        public void Delete(ShowcaseExperience t)
        {
            _showcaseExperienceDal.Delete(t);
        }

        public ShowcaseExperience GetById(int id)
        {
            return _showcaseExperienceDal.GetById(id);
        }

        public List<ShowcaseExperience> GetListAll()
        {
            return _showcaseExperienceDal.GetListAll();
        }

        public void Insert(ShowcaseExperience t)
        {
            _showcaseExperienceDal.Insert(t);
        }

        public void Update(ShowcaseExperience t)
        {
            _showcaseExperienceDal.Update(t);
        }
    }
}
