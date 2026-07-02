using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadP()
        {
            return PartialView();
        }
        public PartialViewResult PreLoaderP()
        {
            return PartialView();
        }
        public PartialViewResult NavHeaderP()
        {
            return PartialView();
        }
        public PartialViewResult HeaderP()
        {
            return PartialView();
        }
        public PartialViewResult SidearP()
        {
            return PartialView();
        }
        public PartialViewResult FooterP()
        {
            return PartialView();
        }
    }
}
