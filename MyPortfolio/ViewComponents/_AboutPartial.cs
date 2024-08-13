using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IAboutSectionService _aboutSectionService;
        private readonly IAboutSectionDescriptionService _aboutSectionDescriptionService;

        public _AboutPartial(IAboutSectionService aboutSectionService, IAboutSectionDescriptionService aboutSectionDescriptionService)
        {
            _aboutSectionService = aboutSectionService;
            _aboutSectionDescriptionService = aboutSectionDescriptionService;
        }

        public IViewComponentResult Invoke()
        {
            var aboutSections = _aboutSectionService.GetListAll();
            var aboutSectionDescriptions = _aboutSectionDescriptionService.GetListAll();

            var viewModel = new AboutSectionViewModel
            {
                AboutSections = aboutSections,
                AboutSectionDescriptions = aboutSectionDescriptions
            };

            return View(viewModel);
        }
    }
}
