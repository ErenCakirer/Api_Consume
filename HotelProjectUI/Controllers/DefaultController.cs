using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
