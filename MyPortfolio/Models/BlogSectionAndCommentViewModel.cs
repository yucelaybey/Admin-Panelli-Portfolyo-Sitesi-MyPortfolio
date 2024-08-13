using EntityLayer.Concrete;

namespace MyPortfolio.Models
{
    public class BlogSectionAndCommentViewModel
    {
        public List<BlogSection>? BlogSections { get; set; }
        public List<Comment>? GetComments { get; set; }
        public BlogSection? Blogs { get; set; }
        public Comment? Comment { get; set; }
    }
}
