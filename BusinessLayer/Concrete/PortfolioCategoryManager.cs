using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioCategoryManager : IPortfolioCategoryService
    {
        private readonly IPortfolioCategoryDal _portfolioCategoryDal;

        public PortfolioCategoryManager(IPortfolioCategoryDal portfolioCategoryDal)
        {
            _portfolioCategoryDal = portfolioCategoryDal;
        }

        public void Delete(PortfolioCategory t)
        {
            _portfolioCategoryDal.Delete(t);
        }

        public IEnumerable<PortfolioCategory> GetAllCategories()
        {
            return _portfolioCategoryDal.GetListAll();
        }

        public PortfolioCategory GetById(int id)
        {
            return _portfolioCategoryDal.GetById(id);
        }

        public List<PortfolioCategory> GetListAll()
        {
            return _portfolioCategoryDal.GetListAll();
        }

        public void Insert(PortfolioCategory t)
        {
            _portfolioCategoryDal.Insert(t);
        }

        public void Update(PortfolioCategory t)
        {
            _portfolioCategoryDal.Update(t);
        }
    }
}
