using HotelProjectEntity.Concrete;
using HotelProjectUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProjectUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var username = User.Identity?.Name;
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Index", "Login");
            }

            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return RedirectToAction("Index", "Login");
            }

            UserEditVM userEditVM = new UserEditVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Username = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty
            };

            return View(userEditVM);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditVM userEditVM)
        {
            if (userEditVM.Password == userEditVM.ConfirmPassword)
            {
                var username = User.Identity?.Name ?? string.Empty;
                var user = await _userManager.FindByNameAsync(username);

                if (user == null)
                {
                    return RedirectToAction("Index", "Login");
                }
                user.Name = userEditVM.Name;
                user.Surname = userEditVM.Surname;
                user.Email = userEditVM.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditVM.Password);

                await _userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Login");
            }
            ModelState.AddModelError("", "Girdiğiniz şifreler birbiriyle uyuşmuyor şef!");
            return View(userEditVM);
        }
    }
}
