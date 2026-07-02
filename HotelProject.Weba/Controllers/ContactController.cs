using HotelProjectBusiness.Abstract;
using HotelProjectEntity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Weba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService; 
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
         contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.Insert(contact); 
            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.GetByID(id);
            return Ok();
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
        return Ok(     _contactService.GetContactCount());
        }
    }
}
