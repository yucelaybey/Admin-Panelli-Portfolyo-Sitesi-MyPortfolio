using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class _FooterPartial : ViewComponent
    {
        private readonly IHomeSectionService _homeSectionService;
        private readonly ISocialMediaSectionService _socialMediaSectionService;

        public _FooterPartial(IHomeSectionService homeSectionService, ISocialMediaSectionService socialMediaSectionService)
        {
            _homeSectionService = homeSectionService;
            _socialMediaSectionService = socialMediaSectionService;
        }

        public IViewComponentResult Invoke()
        {
            var homeSection = _homeSectionService.GetListAll();
            var socialMediaSections = _socialMediaSectionService.GetListAll();

            var viewModel = new HomeSectionToSocialMediaSection
            {
                HomeSections = homeSection,
                SocialMediaSections = socialMediaSections
            };

            return View(viewModel);
        }
    }
}
