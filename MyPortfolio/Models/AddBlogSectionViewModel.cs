using EntityLayer.Concrete;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class AddBlogSectionViewModel
    {
        public BlogSection BlogSection { get; set; }
        public List<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
