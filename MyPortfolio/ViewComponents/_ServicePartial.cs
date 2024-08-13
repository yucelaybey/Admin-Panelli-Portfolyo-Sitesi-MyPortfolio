using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IServiceSectionService _serviceSectionService;

        public _ServicePartial(IServiceSectionService serviceSectionService)
        {
            _serviceSectionService = serviceSectionService;
        }

        public IViewComponentResult Invoke()
        {
            var values =_serviceSectionService.GetListAll();
            return View(values);
        }
    }
}
