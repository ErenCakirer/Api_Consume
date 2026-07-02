using HotelProjectEntity.Concrete;
using HotelProjectUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
            private readonly UserManager<AppUser> _userManager;

            public RegisterController(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            
            if (!ModelState.IsValid)
            {
                return View(createNewUserDto);
            }

            var appuser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                City = "İstanbul",
                Country="Türkiye",
                ImageUrl = "/hotel-html-template/img/user.png",
                WorkLocationDepartment = "Resepsiyon",
                WorkLocationID = 1

            };

            var result = await _userManager.CreateAsync(appuser, createNewUserDto.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(createNewUserDto);
        }
    }
}
