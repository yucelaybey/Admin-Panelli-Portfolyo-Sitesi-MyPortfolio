using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Text.Json;

namespace MyPortfolio.ViewComponents
{
    public class _BlogPartial : ViewComponent
    {
        private readonly IBlogSectionService _blogSectionService;
        private readonly ICommentService _commentService;

        public _BlogPartial(IBlogSectionService blogSectionService, ICommentService commentService)
        {
            _blogSectionService = blogSectionService;
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            var blogSections = _blogSectionService.GetListAll();
            var comments = _commentService.GetListAll();

            var viewModel = new BlogSectionAndCommentViewModel
            {
                BlogSections = blogSections,  // İlk BlogSection'ı atama (veya belirli bir BlogSection'ı seçebilirsiniz)
                GetComments = comments   // İlk yorumu atama (veya belirli bir yorumu seçebilirsiniz)
            };

            return View(viewModel);
        }

    }

}
