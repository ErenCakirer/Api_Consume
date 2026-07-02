using HotelProjectBusiness.Abstract;
using HotelProjectEntity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Weba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.Insert(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            if (id == 0)
            {
                return BadRequest("ID değeri 0 geldi.");
            }

            var values = _guestService.GetByID(id);

            if (values != null)
            {
                _guestService.Delete(values);
                return Ok();
            }

            return NotFound("Silinecek misafir bulunamadı.");
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.Update(guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var values = _guestService.GetByID(id);
        
            return Ok(values);
        }
    }
}