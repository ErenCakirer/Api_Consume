using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class HeadPcs:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
