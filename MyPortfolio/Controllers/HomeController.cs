using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MyPortfolio.Models;

namespace MyPortfolio.Controllers
{

    public class HomeController : Controller
    {
        private readonly IContactSectionService _contactSectionService;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IContactSectionService contactSectionService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _contactSectionService = contactSectionService;
        }

        public IActionResult Index(bool showLoginModal = false)
        {
            ViewBag.ShowLoginModal = showLoginModal;
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                // Hatalı durumlarda Index sayfasına yönlendirirken query string ekleyin
                return RedirectToAction("Index", "Home", new { showLoginModal = true });
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("AdminPanelMainPage", "Admin");
            }

            ModelState.AddModelError(string.Empty, "Geçersiz giriş denemesi.");
            return RedirectToAction("Index", "Home", new { showLoginModal = true });
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AddContactSection()
        {
            var values = _contactSectionService.GetListAll();
            return View(values);
        }

        [HttpPost]
        public IActionResult AddContactSection(ContactSection contactSection)
        {
            if (ModelState.IsValid)
            {
                _contactSectionService.Insert(contactSection);
                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi!";
                return RedirectToAction("Index", "Home");
            }

            var values = _contactSectionService.GetListAll();
            return View(values);
        }
    }
}
