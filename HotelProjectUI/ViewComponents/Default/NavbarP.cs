using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class NavbarP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
