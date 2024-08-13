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
    public class ExperienceSectionManager : IExperienceSectionService
    {
        private readonly IExperienceSectionDal _experienceSectionDal;

        public ExperienceSectionManager(IExperienceSectionDal experienceSectionDal)
        {
            _experienceSectionDal = experienceSectionDal;
        }

        public void Delete(ExperienceSection t)
        {
            _experienceSectionDal.Delete(t);
        }

        public ExperienceSection GetById(int id)
        {
            return _experienceSectionDal.GetById(id);
        }

        public List<ExperienceSection> GetListAll()
        {
            return _experienceSectionDal.GetListAll();
        }

        public void Insert(ExperienceSection t)
        {
            _experienceSectionDal.Insert(t);
        }

        public void Update(ExperienceSection t)
        {
            _experienceSectionDal.Update(t);
        }
    }
}
