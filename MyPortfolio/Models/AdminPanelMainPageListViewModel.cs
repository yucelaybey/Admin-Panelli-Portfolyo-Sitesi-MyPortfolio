using EntityLayer.Concrete;

namespace MyPortfolio.Models
{
    public class AdminPanelMainPageListViewModel
    {
        public List<ContactSection> ContactSections { get; set; }
        public List<HomeSection> HomeSections { get; set; }
        public IEnumerable<HomeSectionDescription> HomeSectionDescriptions { get; set; }
        public List<Comment> Comments { get; set; }
        public List<AboutSection> AboutSections { get; set; }
        public List<PortfolioSection> PortfolioSections { get; set; }
        public List<BlogSection> BlogSections { get; set; }
        public List<TestimonialSection> TestimonialSections { get; set; }
        public List<SocialMediaSection> SocialMediaSections { get; set; }
        public List<ShowcaseExperience> ShowcaseExperiences { get; set; }
    }
}
