using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class SliderP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
