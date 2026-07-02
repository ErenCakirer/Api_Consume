using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Default
{
    public class ReservationP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
