using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IAboutSectionService _aboutSectionService;
        private readonly IAboutSectionDescriptionService _aboutSectionDescriptionService;
        private readonly IServiceSectionService _serviceSectionService;
        private readonly IExperienceSectionService _experienceSectionService;
        private readonly IPortfolioSectionService _portfolioSectionService;
        private readonly IPortfolioCategoryService _portfolioCategoryService;
        private readonly IBlogSectionService _blogSectionService;
        private readonly ICommentService _commentService;
        private readonly IContactSectionService _contactSectionService;
        private readonly IHomeSectionService _homeSectionService;
        private readonly IHomeSectionDescriptionService _homeSectionDescriptionService;
        private readonly ITestimonialSectionService _testimonialSectionService;
        private readonly ISocialMediaSectionService _socialMediaSectionService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IShowcaseExperienceService _showcaseExperienceService;

        public AdminController(IAboutSectionService aboutSectionService, IAboutSectionDescriptionService aboutSectionDescriptionService, IServiceSectionService serviceSectionService, IExperienceSectionService experienceSectionService, IPortfolioSectionService portfolioSectionService, IPortfolioCategoryService portfolioCategoryService, IBlogSectionService blogSectionService, ICommentService commentService, IContactSectionService contactSectionService, IHomeSectionService homeSectionService, IHomeSectionDescriptionService homeSectionDescriptionService, ITestimonialSectionService testimonialSectionService, ISocialMediaSectionService socialMediaSectionService, UserManager<IdentityUser> userManager, IShowcaseExperienceService showcaseExperienceService)
        {
            _aboutSectionService = aboutSectionService;
            _aboutSectionDescriptionService = aboutSectionDescriptionService;
            _serviceSectionService = serviceSectionService;
            _experienceSectionService = experienceSectionService;
            _portfolioSectionService = portfolioSectionService;
            _portfolioCategoryService = portfolioCategoryService;
            _blogSectionService = blogSectionService;
            _commentService = commentService;
            _contactSectionService = contactSectionService;
            _homeSectionService = homeSectionService;
            _homeSectionDescriptionService = homeSectionDescriptionService;
            _testimonialSectionService = testimonialSectionService;
            _socialMediaSectionService = socialMediaSectionService;
            _userManager = userManager;
            _showcaseExperienceService = showcaseExperienceService;
        }

        public IActionResult AdminPanelMainPage()
        {
            ViewBag.ActiveMenu = "AdminPanelMainPage";
            var contactSection = _contactSectionService.GetListAll();
            var homeSection = _homeSectionService.GetListAll();
            var homeSectionDescripton = _homeSectionDescriptionService.GetListAll();
            var comment = _commentService.GetListAll();
            var aboutSection = _aboutSectionService.GetListAll();
            var portfolioSection = _portfolioSectionService.GetListAll();
            var blogSection = _blogSectionService.GetListAll();
            var testimonialSection = _testimonialSectionService.GetListAll();
            var socialMediaSection = _socialMediaSectionService.GetListAll();
            var showcaseExperience = _showcaseExperienceService.GetListAll();

            var viewModel = new AdminPanelMainPageListViewModel
            {
                ContactSections = contactSection,
                HomeSections = homeSection,
                HomeSectionDescriptions = homeSectionDescripton,
                Comments = comment,
                AboutSections = aboutSection,
                PortfolioSections = portfolioSection,
                BlogSections = blogSection,
                TestimonialSections = testimonialSection,
                SocialMediaSections = socialMediaSection,
                ShowcaseExperiences = showcaseExperience
            };

            return View(viewModel);
        }

        //AboutSection  //AboutSection //AboutSection //AboutSection


        public IActionResult AboutSection()
        {
            ViewBag.ActiveMenu = "AboutSection";
            var aboutSections = _aboutSectionService.GetListAll();
            var aboutSectionDescriptions = _aboutSectionDescriptionService.GetListAll();

            var viewModel = new AboutSectionViewModel
            {
                AboutSections = aboutSections,
                AboutSectionDescriptions = aboutSectionDescriptions
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddAboutSection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAboutSection(AboutSection aboutSection)
        {
            _aboutSectionService.Insert(aboutSection);
            return RedirectToAction("AboutSection");
        }

        [HttpGet]
        public IActionResult UpdateAboutSection(int id)
        {
            var values = _aboutSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAboutSection(AboutSection aboutSection)
        {
            _aboutSectionService.Update(aboutSection);
            return RedirectToAction("AboutSection");
        }

        public IActionResult DeleteAboutSection(int id)
        {
            var value = _aboutSectionService.GetById(id);
            if (value == null)
            {
                return NotFound();
            }

            _aboutSectionService.Delete(value);
            return RedirectToAction("AboutSection");
        }

        //AboutSectionDescription //AboutSectionDescription //AboutSectionDescription //AboutSectionDescription

        [HttpGet]
        public IActionResult AddAboutSectionDescription()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAboutSectionDescription(AboutSectionDescription aboutSectionDescription)
        {
            _aboutSectionDescriptionService.Insert(aboutSectionDescription);
            return RedirectToAction("AboutSection");
        }

        [HttpGet]
        public IActionResult UpdateAboutSectionDescription(int id)
        {
            var values = _aboutSectionDescriptionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAboutSectionDescription(AboutSectionDescription aboutSectionDescription)
        {
            _aboutSectionDescriptionService.Update(aboutSectionDescription);
            return RedirectToAction("AboutSection");
        }

        public IActionResult DeleteAboutSectionDescription(int id)
        {
            var value = _aboutSectionDescriptionService.GetById(id);
            if (value == null)
            {
                return NotFound();
            }

            _aboutSectionDescriptionService.Delete(value);
            return RedirectToAction("AboutSection");
        }

        //ServiceSection //ServiceSection //ServiceSection //ServiceSection

        public IActionResult ServiceSection()
        {
            ViewBag.ActiveMenu = "ServiceSection";
            var values = _serviceSectionService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddServiceSection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddServiceSection(ServiceSection serviceSection)
        {
            _serviceSectionService.Insert(serviceSection);
            return RedirectToAction("ServiceSection");
        }

        [HttpGet]
        public IActionResult UpdateServiceSection(int id)
        {
            var values = _serviceSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateServiceSection(ServiceSection serviceSection)
        {
            _serviceSectionService.Update(serviceSection);
            return RedirectToAction("ServiceSection");
        }

        public IActionResult DeleteServiceSection(int id)
        {
            var values = _serviceSectionService.GetById(id);
            _serviceSectionService.Delete(values);
            return RedirectToAction("ServiceSection");

        }

        //ExperienceSection //ExperienceSection //ExperienceSection //ExperienceSection

        public IActionResult ExperienceSection()
        {
            ViewBag.ActiveMenu = "ExperienceSection";
            var experienceSection = _experienceSectionService.GetListAll();


            return View(experienceSection);
        }

        [HttpGet]
        public IActionResult AddExperienceSection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperienceSection(ExperienceSection experienceSection)
        {
            _experienceSectionService.Insert(experienceSection);
            return RedirectToAction("ExperienceSection");
        }

        [HttpGet]
        public IActionResult UpdateExperienceSection(int id)
        {
            var values = _experienceSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperienceSection(ExperienceSection experienceSection)
        {
            _experienceSectionService.Update(experienceSection);
            return RedirectToAction("ExperienceSection");
        }

        public IActionResult DeleteExperienceSection(int id)
        {
            var values = _experienceSectionService.GetById(id);
            _experienceSectionService.Delete(values);
            return RedirectToAction("ExperienceSection");

        }

        //PortfolioSection //PortfolioSection //PortfolioSection //PortfolioSection //PortfolioSection //PortfolioSection

        public IActionResult PortfolioSection()
        {
            ViewBag.ActiveMenu = "PortfolioSection";
            var portfolioSections = _portfolioSectionService.GetListAll();
            var portfolioCategories = _portfolioCategoryService.GetListAll();

            var viewModel = new PortfolioSectionListViewModel
            {
                PortfolioSections = portfolioSections,
                PortfolioCategories = portfolioCategories
            };

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult AddPortfolioSection()
        {
            var viewModel = new AddPortfolioSectionViewModel
            {
                Categories = _portfolioCategoryService.GetAllCategories()
                    .Select(c => new SelectListItem
                    {
                        Value = c.CategoryName,
                        Text = c.CategoryName
                    }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddPortfolioSection(AddPortfolioSectionViewModel viewModel)
        {
            ModelState.Remove("Categories");

            if (ModelState.IsValid)
            {
                // PortfolioSection içine kategoriyi ekliyoruz
                viewModel.PortfolioSection.CategoryName = viewModel.SelectedCategory;

                _portfolioSectionService.AddPortfolioSection(viewModel.PortfolioSection);
                return RedirectToAction("PortfolioSection");
            }

            // Eğer ModelState geçersizse, aynı view model ile view'e geri dönüyoruz
            viewModel.Categories = _portfolioCategoryService.GetAllCategories()
                .Select(c => new SelectListItem
                {
                    Value = c.CategoryName,
                    Text = c.CategoryName
                }).ToList();

            return View(viewModel);
        }



        [HttpGet]
        public IActionResult UpdatePortfolioSection(int id)
        {
            var portfolioSection = _portfolioSectionService.GetById(id);
            if (portfolioSection == null)
            {
                return NotFound();
            }

            var categories = _portfolioCategoryService.GetAllCategories();

            var viewModel = new AddPortfolioSectionViewModel
            {
                PortfolioSection = portfolioSection,
                Categories = categories
                    .Select(c => new SelectListItem
                    {
                        Value = c.CategoryName,
                        Text = c.CategoryName,
                        Selected = c.CategoryName == portfolioSection.CategoryName // Mevcut kategori seçili olacak
                    }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdatePortfolioSection(AddPortfolioSectionViewModel viewModel)
        {
            ModelState.Remove("Categories");
            if (ModelState.IsValid)
            {
                var updatedSection = viewModel.PortfolioSection;
                updatedSection.CategoryName = viewModel.PortfolioSection.CategoryName; // Güncellenmiş kategori adını al

                _portfolioSectionService.Update(updatedSection);
                return RedirectToAction("PortfolioSection");
            }

            // Hatalı olduğunda kategori listesini yeniden getir
            viewModel.Categories = _portfolioCategoryService.GetAllCategories()
                .Select(c => new SelectListItem
                {
                    Value = c.CategoryName,
                    Text = c.CategoryName,
                    Selected = c.CategoryName == viewModel.PortfolioSection.CategoryName // Seçili olanı koruyun
                }).ToList();

            return View(viewModel);
        }


        public IActionResult DeletePortfolioSection(int id)
        {
            var portfolioSection = _portfolioSectionService.GetById(id);
            if (portfolioSection != null)
            {
                _portfolioSectionService.Delete(portfolioSection);
            }
            return RedirectToAction("PortfolioSection");
        }

        //PortfolioCategory //PortfolioCategory //PortfolioCategory //PortfolioCategory //PortfolioCategory //PortfolioCategory

        [HttpGet]
        public IActionResult AddPortfolioCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolioCategory(PortfolioCategory portfolioCategory)
        {
            _portfolioCategoryService.Insert(portfolioCategory);
            return RedirectToAction("PortfolioSection");
        }

        [HttpGet]
        public IActionResult UpdatePortfolioCategory(int id)
        {
            var values = _portfolioCategoryService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePortfolioCategory(PortfolioCategory portfolioCategory)
        {
            _portfolioCategoryService.Update(portfolioCategory);
            return RedirectToAction("PortfolioSection");
        }

        public IActionResult DeletePortfolioCategory(int id)
        {
            var value = _portfolioCategoryService.GetById(id);
            if (value == null)
            {
                return NotFound();
            }

            _portfolioCategoryService.Delete(value);
            return RedirectToAction("PortfolioSection");
        }

        //BlogSection //BlogSection //BlogSection //BlogSection //BlogSection //BlogSection //BlogSection //BlogSection //BlogSection

        public IActionResult BlogSection()
        {
            ViewBag.ActiveMenu = "BlogSection";
            var blogSections = _blogSectionService.GetListAll();
            var comments = _commentService.GetListAll();

            var viewModel = new BlogSectionListViewModel
            {
                BlogSections = blogSections,
                Comments = comments
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddBlogSection()
        {
            var viewModel = new AddBlogSectionViewModel
            {
                BlogSection = new BlogSection(), // Yeni bir BlogSection oluşturuluyor
                PortfolioCategories = _portfolioCategoryService.GetListAll() // Tüm kategorileri alıyoruz
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddBlogSection(AddBlogSectionViewModel viewModel)
        {
            ModelState.Remove("PortfolioCategories");
            ModelState.Remove("BlogSection.Comments");
            if (ModelState.IsValid)
            {
                _blogSectionService.Insert(viewModel.BlogSection); // BlogSection veritabanına eklenir
                return RedirectToAction("BlogSection"); // Başarıyla ekledikten sonra yönlendirme yapılır
            }

            // Model geçerli değilse, kategori listesini tekrar yükle
            viewModel.PortfolioCategories = _portfolioCategoryService.GetListAll();
            return View(viewModel); // Form tekrar gösterilir
        }

        [HttpGet]
        public IActionResult UpdateBlogSection(int id)
        {
            var blogSection = _blogSectionService.GetById(id);
            if (blogSection == null)
            {
                return NotFound();
            }

            var viewModel = new UpdateBlogSectionViewModel
            {
                BlogSection = blogSection,
                PortfolioCategories = _portfolioCategoryService.GetListAll()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult UpdateBlogSection(UpdateBlogSectionViewModel viewModel)
        {
            ModelState.Remove("PortfolioCategories");

            if (!ModelState.IsValid)
            {
                viewModel.PortfolioCategories = _portfolioCategoryService.GetListAll(); // Kategorileri yeniden al
                return View(viewModel);
            }

            var existingBlogSection = _blogSectionService.GetById(viewModel.BlogSection.BlogSectionID);

            if (existingBlogSection == null)
            {
                return NotFound();
            }

            // Eski BlogTime değerini koruyarak güncelleme yapıyoruz
            viewModel.BlogSection.BlogTime = existingBlogSection.BlogTime;

            // Kategoriyi güncelle
            existingBlogSection.BlogCategory = viewModel.BlogSection.BlogCategory;

            // BlogSection'ı güncelle
            _blogSectionService.Update(existingBlogSection);

            // Başarıyla güncellendiğinde, liste sayfasına yönlendir
            return RedirectToAction("BlogSection");
        }


        public IActionResult DeleteBlogSection(int id)
        {
            var value = _blogSectionService.GetById(id);
            if (value == null)
            {
                return NotFound();
            }

            _blogSectionService.Delete(value);
            return RedirectToAction("BlogSection");
        }

        [HttpPost]
        public IActionResult AddComment()
        {
            var blogSectionID = Request.Form["BlogSectionID"];
            var name = Request.Form["Name"];
            var email = Request.Form["Email"];
            var message = Request.Form["Message"];

            Console.WriteLine($"BlogSectionID: {blogSectionID}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Message: {message}");

            // Burada model oluşturup veriyi işleyebilirsiniz
            var comment = new Comment
            {
                BlogSectionID = int.Parse(blogSectionID),
                CommentPersonName = name,
                CommentPersonMail = email,
                CommentPersonMessage = message
            };
            ModelState.Remove("BlogSection");
            if (ModelState.IsValid)
            {
                _commentService.Insert(comment);
                return RedirectToAction("Index", "Home", new { id = comment.BlogSectionID, anchor = $"modal-{comment.BlogSectionID}" });
            }

            // ModelState geçerli değilse, formu yeniden göster
            return RedirectToAction("Index", "Home", new { id = comment.BlogSectionID, anchor = $"modal-{comment.BlogSectionID}" });
        }





        public IActionResult DeleteCommentSection(int id)
        {
            var value = _commentService.GetById(id);
            if (value == null)
            {
                return NotFound();
            }

            _commentService.Delete(value);
            return RedirectToAction("BlogSection");
        }

        //ContactSection //ContactSection //ContactSection //ContactSection //ContactSection //ContactSection //ContactSection //ContactSection

        public IActionResult ContactSection()
        {
            ViewBag.ActiveMenu = "ContactSection";
            var values = _contactSectionService.GetListAll();
            return View(values);
        }

        public IActionResult DeleteContactSection(int id)
        {
            var values = _contactSectionService.GetById(id);
            _contactSectionService.Delete(values);
            return RedirectToAction("ContactSection");
        }

        //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection //HomeSection

        [HttpGet]
        public IActionResult AddHomeSection()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddHomeSection(HomeSection homeSection)
        {
            _homeSectionService.Insert(homeSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        [HttpGet]
        public IActionResult UpdateHomeSection(int id)
        {
            var values = _homeSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateHomeSection(HomeSection homeSection)
        {
            _homeSectionService.Update(homeSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        public IActionResult DeleteHomeSection(int id)
        {
            var values = _homeSectionService.GetById(id);
            _homeSectionService.Delete(values);
            return RedirectToAction("AdminPanelMainPage");
        }

        //HomeSectionDescription //HomeSectionDescription //HomeSectionDescription //HomeSectionDescription //HomeSectionDescription //HomeSectionDescription

        [HttpGet]
        public IActionResult AddHomeSectionDescription()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddHomeSectionDescription(HomeSectionDescription homeSectionDescription)
        {
            _homeSectionDescriptionService.Insert(homeSectionDescription);
            return RedirectToAction("AdminPanelMainPage");
        }

        [HttpGet]
        public IActionResult UpdateHomeSectionDescription(int id)
        {
            var values = _homeSectionDescriptionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateHomeSectionDescription(HomeSectionDescription homeSectionDescription)
        {
            _homeSectionDescriptionService.Update(homeSectionDescription);
            return RedirectToAction("AdminPanelMainPage");
        }

        public IActionResult DeleteHomeSectionDescription(int id)
        {
            var values = _homeSectionDescriptionService.GetById(id);
            _homeSectionDescriptionService.Delete(values);
            return RedirectToAction("AdminPanelMainPage");
        }

        //TestimonialSection //TestimonialSection //TestimonialSection //TestimonialSection //TestimonialSection //TestimonialSection //TestimonialSection

        [HttpGet]
        public IActionResult AddTestimonialSection()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonialSection(TestimonialSection testimonialSection)
        {
            _testimonialSectionService.Insert(testimonialSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        [HttpGet]
        public IActionResult UpdateTestimonialSection(int id)
        {
            var values = _testimonialSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonialSection(TestimonialSection testimonialSection)
        {
            _testimonialSectionService.Update(testimonialSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        public IActionResult DeleteTestimonialSection(int id)
        {
            var values = _testimonialSectionService.GetById(id);
            _testimonialSectionService.Delete(values);
            return RedirectToAction("AdminPanelMainPage");
        }

        //SocialMediaSection //SocialMediaSection //SocialMediaSection //SocialMediaSection //SocialMediaSection //SocialMediaSection //SocialMediaSection

        [HttpGet]
        public IActionResult AddSocialMediaSection()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddSocialMediaSection(SocialMediaSection socialMediaSection)
        {
            _socialMediaSectionService.Insert(socialMediaSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        [HttpGet]
        public IActionResult UpdateSocialMediaSection(int id)
        {
            var values = _socialMediaSectionService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMediaSection(SocialMediaSection socialMediaSection)
        {
            _socialMediaSectionService.Update(socialMediaSection);
            return RedirectToAction("AdminPanelMainPage");
        }

        public IActionResult DeleteSocialMediaSection(int id)
        {
            var values = _socialMediaSectionService.GetById(id);
            _socialMediaSectionService.Delete(values);
            return RedirectToAction("AdminPanelMainPage");
        }

        //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection //AdminSection

        public async Task<IActionResult> AdminSection()
        {
            ViewBag.ActiveMenu = "AdminSection";
            var users = await _userManager.Users.ToListAsync();

            if (users == null)
            {
                users = new List<IdentityUser>();
            }

            return View(users);
        }

        public IActionResult AddAdminSection()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddAdminSection(string email, string password)
        {
            if (ModelState.IsValid)
            {
                // Yeni bir kullanıcı oluştur
                var user = new IdentityUser
                {
                    UserName = email,
                    Email = email
                };

                // Kullanıcıyı oluştur
                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    // Kullanıcı başarıyla oluşturuldu, admin listeleme sayfasına yönlendir
                    return RedirectToAction("AdminSection");
                }
                else
                {
                    // Hata mesajlarını ModelState'e ekle
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            // ModelState geçersizse formu tekrar göster
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> UpdateAdminSection(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("AdminSection");
            }

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAdminSection(string id, string Email, string Password)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(Email))
            {
                user.Email = Email;
                user.UserName = Email; // Eğer UserName email ise
            }

            if (!string.IsNullOrEmpty(Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, Password);
                if (!result.Succeeded)
                {
                    // Hata mesajlarını ekleyebilirsiniz
                    ModelState.AddModelError(string.Empty, "Şifre güncellenemedi.");
                    return View(user);
                }
            }

            var updateResult = await _userManager.UpdateAsync(user);
            if (updateResult.Succeeded)
            {
                return RedirectToAction("AdminSection");
            }

            // Hata mesajlarını ekleyebilirsiniz
            return View(user);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteAdminSection(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("AdminSection"); // Silme işlemi başarılıysa admin listesine geri dön
                }
            }
            return NotFound(); // Kullanıcı bulunamazsa 404 sayfası döner
        }

        //ShowcaseExperience //ShowcaseExperience //ShowcaseExperience //ShowcaseExperience //ShowcaseExperience //ShowcaseExperience

        [HttpGet]
        public IActionResult AddShowcaseExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddShowcaseExperience(ShowcaseExperience showcaseExperience)
        {
            _showcaseExperienceService.Insert(showcaseExperience);
            return RedirectToAction("AdminPanelMainPage");
        }

        [HttpGet]
        public IActionResult UpdateShowcaseExperience(int id)
        {
            var values = _showcaseExperienceService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateShowcaseExperience(ShowcaseExperience showcaseExperience)
        {
            _showcaseExperienceService.Update(showcaseExperience);
            return RedirectToAction("AdminPanelMainPage");
        }

        public IActionResult DeleteShowcaseExperience(int id)
        {
            var values = _showcaseExperienceService.GetById(id);
            _showcaseExperienceService.Delete(values);
            return RedirectToAction("AdminPanelMainPage");

        }
    }

}
