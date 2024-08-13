using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimonialSectionService _testimonialSectionService;

        public _TestimonialPartial(ITestimonialSectionService testimonialSectionService)
        {
            _testimonialSectionService = testimonialSectionService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialSectionService.GetListAll();
            return View(values);
        }
    }
}
