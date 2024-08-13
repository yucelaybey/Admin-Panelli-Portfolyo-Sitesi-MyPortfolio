using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class _HeroPartial : ViewComponent
    {
        private readonly IHomeSectionDescriptionService _homeSectionDescriptionService;
        private readonly IHomeSectionService _homeSectionService;
        private readonly IShowcaseExperienceService _showcaseExperienceService;

        public _HeroPartial(IHomeSectionDescriptionService homeSectionDescriptionService, IHomeSectionService homeSectionService, IShowcaseExperienceService showcaseExperienceService)
        {
            _homeSectionDescriptionService = homeSectionDescriptionService;
            _homeSectionService = homeSectionService;
            _showcaseExperienceService = showcaseExperienceService;
        }

        public IViewComponentResult Invoke()
        {
            var homeSection = _homeSectionService.GetListAll();
            var homeSectionDescripton = _homeSectionDescriptionService.GetListAll();
            var showcaseExperience = _showcaseExperienceService.GetListAll();

            var viewModel = new HomeSectionToDescriptionViewModel
            {
                HomeSections = homeSection,
                HomeSectionDescriptions = homeSectionDescripton,
                ShowcaseExperiences = showcaseExperience
            };

            return View(viewModel);
        }
    }
}
