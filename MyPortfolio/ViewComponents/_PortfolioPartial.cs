using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioPartial : ViewComponent
    {
        private readonly IPortfolioSectionService _portfolioSectionService;
        private readonly IPortfolioCategoryService _portfolioCategoryService;

        public _PortfolioPartial(IPortfolioSectionService portfolioSectionService, IPortfolioCategoryService portfolioCategoryService)
        {
            _portfolioSectionService = portfolioSectionService;
            _portfolioCategoryService = portfolioCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var portfolioSection = _portfolioSectionService.GetListAll();
            var portfolioCategory = _portfolioCategoryService.GetListAll();

            var viewModel = new PortfolioSectionListViewModel
            {
                PortfolioSections = portfolioSection,
                PortfolioCategories = portfolioCategory
            };

            return View(viewModel);
        }
    }
}
