    using HotelProjectEntity.Concrete;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    namespace HotelProjectUI.Controllers
    {
        [AllowAnonymous]
        public class AdminUserController : Controller
        {
            private readonly UserManager<AppUser > _userManager;

            public AdminUserController(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }

            public IActionResult Index()
            {
                var values=_userManager.Users.ToList();
                return View(values);
            }
        }
    }
