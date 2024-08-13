using EntityLayer.Concrete;

namespace MyPortfolio.Models
{
    public class BlogSectionListViewModel
    {
        public List<BlogSection> BlogSections { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
