using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class TrailerP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
