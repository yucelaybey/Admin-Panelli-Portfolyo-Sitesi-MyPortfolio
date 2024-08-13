using EntityLayer.Concrete;

namespace MyPortfolio.Models
{
    public class HomeSectionToDescriptionViewModel
    {
        public List<HomeSection> HomeSections { get; set; }
        public List<HomeSectionDescription> HomeSectionDescriptions { get; set; }
        public List<ShowcaseExperience> ShowcaseExperiences { get; set; }
    }
}
