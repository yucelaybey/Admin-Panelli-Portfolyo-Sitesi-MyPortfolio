using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MyPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<MyPorfolioContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                // Lockout ayarlarýný kaldýr
                options.SignIn.RequireConfirmedAccount = false;
                options.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                options.Lockout.MaxFailedAccessAttempts = 0; // Lockout özelliðini devre dýþý býrak
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(0);
                options.User.RequireUniqueEmail = true;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
            })
.AddEntityFrameworkStores<MyPorfolioContext>()
.AddDefaultTokenProviders();

            // Add services to the container.
            builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IAboutSectionDescriptionService, AboutSectionDescriptionManager>();
            builder.Services.AddScoped<IAboutSectionDescriptionDal, EfAboutSectionDescriptionDal>();
            builder.Services.AddScoped<IAboutSectionService, AboutSectionManager>();
            builder.Services.AddScoped<IAboutSectionDal, EfAboutSectionDal>();
            builder.Services.AddScoped<IServiceSectionService, ServiceSectionManager>();
            builder.Services.AddScoped<IServiceSectionDal, EfServiceSectionDal>();
            builder.Services.AddScoped<IExperienceSectionService, ExperienceSectionManager>();
            builder.Services.AddScoped<IExperienceSectionDal, EfExperienceSectionDal>();
            builder.Services.AddScoped<IPortfolioSectionService, PortfolioSectionManager>();
            builder.Services.AddScoped<IPortfolioSectionDal, EfPortfolioSectionDal>();
            builder.Services.AddScoped<IPortfolioCategoryService, PortfolioCategoryManager>();
            builder.Services.AddScoped<IPortfolioCategoryDal, EfPortfolioCategoryDal>();
            builder.Services.AddScoped<IBlogSectionService, BlogSectionManager>();
            builder.Services.AddScoped<IBlogSectionDal, EfBlogSectionDal>();
            builder.Services.AddScoped<ICommentService, CommentManager>();
            builder.Services.AddScoped<ICommentDal, EfCommentDal>();
            builder.Services.AddScoped<IContactSectionService, ContactSectionManager>();
            builder.Services.AddScoped<IContactSectionDal, EfContactSectionDal>();
            builder.Services.AddScoped<IHomeSectionService, HomeSectionManager>();
            builder.Services.AddScoped<IHomeSectionDal, EfHomeSectionDal>();
            builder.Services.AddScoped<IHomeSectionDescriptionService, HomeSectionDescriptionManager>();
            builder.Services.AddScoped<IHomeSectionDescriptionDal, EfHomeSectionDescriptionDal>();
            builder.Services.AddScoped<ITestimonialSectionService, TestimonialSectionManager>();
            builder.Services.AddScoped<ITestimonialSectionDal, EfTestimonialSectionDal>();
            builder.Services.AddScoped<ISocialMediaSectionService, SocialMediaSectionManager>();
            builder.Services.AddScoped<ISocialMediaSectionDal, EfSocialMediaSectionDal>();
            builder.Services.AddScoped<IShowcaseExperienceService, ShowcaseExperienceManager>();
            builder.Services.AddScoped<IShowcaseExperienceDal, EfShowcaseExperienceDal>();


            builder.Services.AddControllersWithViews();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Home/Index?login=true"; // Giriþ yapmadan eriþmeye çalýþanlarý anasayfaya yönlendir
                options.LogoutPath = "/Home/Logout";
                options.AccessDeniedPath = "/Home/Index?login=true";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // Oturum süresi
                options.SlidingExpiration = true; // 'Beni Hatýrla' özelliði
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
