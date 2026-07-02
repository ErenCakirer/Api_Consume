using Microsoft.AspNetCore.Mvc;

namespace HotelProjectUI.ViewComponents.Contact
{
    public class ContactCoverP:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
