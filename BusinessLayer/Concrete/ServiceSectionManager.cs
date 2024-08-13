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
    public class ServiceSectionManager : IServiceSectionService
    {
        private readonly IServiceSectionDal _serviceSectionDal;

        public ServiceSectionManager(IServiceSectionDal serviceSectionDal)
        {
            _serviceSectionDal = serviceSectionDal;
        }

        public void Delete(ServiceSection t)
        {
            _serviceSectionDal.Delete(t);
        }

        public ServiceSection GetById(int id)
        {
            return _serviceSectionDal.GetById(id);
        }

        public List<ServiceSection> GetListAll()
        {
            return _serviceSectionDal.GetListAll();
        }

        public void Insert(ServiceSection t)
        {
            _serviceSectionDal.Insert(t);
        }

        public void Update(ServiceSection t)
        {
            _serviceSectionDal.Update(t);
        }
    }
}
