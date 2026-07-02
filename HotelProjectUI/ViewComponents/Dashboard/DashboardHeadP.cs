using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class DashboardHeadP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
