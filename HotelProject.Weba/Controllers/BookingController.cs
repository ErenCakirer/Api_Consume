using HotelProjectBusiness.Abstract;
using HotelProjectEntity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.Weba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

    
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            
            var values = _bookingService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Insert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            if (values == null)
            {
                return NotFound("Silinecek rezervasyon bulunamadı.");
            }
            _bookingService.Delete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            if (booking.BookingID == 0)
            {
                return BadRequest("Güncellenecek rezervasyonun ID bilgisi API'ye ulaşmadı şef!");
            }

            _bookingService.Update(booking);
            return Ok("Rezervasyon başarıyla güncellendi.");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.GetByID(id);
            if (values == null)
            {
                return NotFound("Rezervasyon bulunamadı.");
            }
            return Ok(values);
        }
        [HttpGet("LastBookings")]
        public IActionResult LastBooking(int id)
        {
            var values = _bookingService.TLastBookings();
            return Ok(values);
        }
        [HttpPut("CancelReservation/{id}")]
        public IActionResult CancelReservation(int id)
        {
            _bookingService.TBookingStatusChangeCancel(id);
            return Ok("Rezervasyon durumu başarıyla 'İptal Edildi' olarak güncellendi.");
        }

    }
}