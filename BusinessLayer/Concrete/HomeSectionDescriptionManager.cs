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
    public class HomeSectionDescriptionManager : IHomeSectionDescriptionService
    {
        private readonly IHomeSectionDescriptionDal _homeSectionDescriptionDal;

        public HomeSectionDescriptionManager(IHomeSectionDescriptionDal homeSectionDescriptionDal)
        {
            _homeSectionDescriptionDal = homeSectionDescriptionDal;
        }

        public void Delete(HomeSectionDescription t)
        {
            _homeSectionDescriptionDal.Delete(t);
        }

        public HomeSectionDescription GetById(int id)
        {
            return _homeSectionDescriptionDal.GetById(id);
        }

        public List<HomeSectionDescription> GetListAll()
        {
            return _homeSectionDescriptionDal.GetListAll();
        }

        public void Insert(HomeSectionDescription t)
        {
            _homeSectionDescriptionDal.Insert(t);
        }

        public void Update(HomeSectionDescription t)
        {
            _homeSectionDescriptionDal.Update(t);
        }
    }
}
