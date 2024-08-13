using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;

namespace MyPortfolio.ViewComponents
{
    public class _ExperiencePartial : ViewComponent
    {
        private readonly IExperienceSectionService _experienceSectionService;

        public _ExperiencePartial(IExperienceSectionService experienceSectionService)
        {
            _experienceSectionService = experienceSectionService;
        }

        public IViewComponentResult Invoke()
        {
            var experienceSection = _experienceSectionService.GetListAll();

            
            return View(experienceSection);
        }
    }
}
