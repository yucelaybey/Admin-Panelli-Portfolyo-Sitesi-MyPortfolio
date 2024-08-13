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
    public class HomeSectionManager : IHomeSectionService
    {
        private readonly IHomeSectionDal _homeSectionDal;

        public HomeSectionManager(IHomeSectionDal homeSectionDal)
        {
            _homeSectionDal = homeSectionDal;
        }

        public void Delete(HomeSection t)
        {
            _homeSectionDal.Delete(t);
        }

        public HomeSection GetById(int id)
        {
            return _homeSectionDal.GetById(id);
        }

        public List<HomeSection> GetListAll()
        {
            return _homeSectionDal.GetListAll();
        }

        public void Insert(HomeSection t)
        {
            _homeSectionDal.Insert(t);
        }

        public void Update(HomeSection t)
        {
            _homeSectionDal.Update(t);
        }
    }
}
