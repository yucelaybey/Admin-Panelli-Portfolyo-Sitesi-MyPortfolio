using EntityLayer.Concrete;

namespace MyPortfolio.Models
{
    public class UpdateBlogSectionViewModel
    {
        public BlogSection BlogSection { get; set; }
        public List<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
