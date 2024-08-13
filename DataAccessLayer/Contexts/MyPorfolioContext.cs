using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Contexts
{
    public class MyPorfolioContext : IdentityDbContext<IdentityUser>
    {
        public MyPorfolioContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<AboutSectionDescription> AboutSectionDescriptions { get; set; }
        public DbSet<BlogSection> BlogSections { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactSection> ContactSections { get; set; }
        public DbSet<ExperienceSection> ExperienceSections { get; set; }
        public DbSet<HomeSection> HomeSections { get; set; }
        public DbSet<HomeSectionDescription> HomeSectionDescriptions { get; set; }
        public DbSet<PortfolioSection> PortfolioSections { get; set; }
        public DbSet<ServiceSection> ServiceSections { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<TestimonialSection> TestimonialSections { get; set; }
        public DbSet<SocialMediaSection> SocialMediaSections { get; set; }
        public DbSet<ShowcaseExperience> ShowcaseExperiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlogSection>()
                .HasMany(b => b.Comments)
                .WithOne(c => c.BlogSection)
                .HasForeignKey(c => c.BlogSectionID);
        }
    }
}
