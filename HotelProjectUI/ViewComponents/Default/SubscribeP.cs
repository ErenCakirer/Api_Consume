using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class SubscribeP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
