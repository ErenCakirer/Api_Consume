using HotelProjectEntity.Concrete;
using HotelProjectUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        private readonly  SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (!ModelState.IsValid)
            {
                // 🎯 EKLENDİ: ModelState'in neden takıldığını sayfaya fırlatıyoruz!
                ModelState.AddModelError("", "Form doğrulama hatası! Lütfen input alanlarını kontrol edin.");
                return View(loginUserDto);
            }

            var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Staff");
            }

            // 🎯 EKLENDİ: Şifre veya kullanıcı adı yanlışsa ekrana bassın
            ModelState.AddModelError("", "Kullanıcı adı veya şifre veritabanıyla eşleşmedi!");

            return View(loginUserDto);
        }
    }
}
