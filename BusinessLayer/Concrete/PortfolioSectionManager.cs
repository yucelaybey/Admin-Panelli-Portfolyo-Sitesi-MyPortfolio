// BusinessLayer/Concrete/PortfolioSectionManager.cs
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PortfolioSectionManager : IPortfolioSectionService
    {
        private readonly IPortfolioSectionDal _portfolioSectionDal;

        public PortfolioSectionManager(IPortfolioSectionDal portfolioSectionDal)
        {
            _portfolioSectionDal = portfolioSectionDal;
        }

        public void AddPortfolioSection(PortfolioSection portfolioSection)
        {
            _portfolioSectionDal.Insert(portfolioSection);
        }

        public void Delete(PortfolioSection t)
        {
            _portfolioSectionDal.Delete(t);
        }

        public PortfolioSection GetById(int id)
        {
            return _portfolioSectionDal.GetById(id);
        }

        public List<PortfolioSection> GetListAll()
        {
            return _portfolioSectionDal.GetListAll();
        }

        public void Insert(PortfolioSection t)
        {
            _portfolioSectionDal.Insert(t);
        }

        public void Update(PortfolioSection t)
        {
            _portfolioSectionDal.Update(t);
        }
    }
}
