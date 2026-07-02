using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class FooterP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
