using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class ServiceP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
