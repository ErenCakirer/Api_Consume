    using HotelProjectUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
  
            createBookingDto.Status = "Onay Bekliyor";
            createBookingDto.Description = "Web sitesinden gelen rezervasyon";
            createBookingDto.SpecialRequest = "Yok";

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

         
            var responseMessage = await client.PostAsync("http://localhost:5027/api/Booking", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
             
                return RedirectToAction("Index", "Default");
            }

        
            var errorContent = await responseMessage.Content.ReadAsStringAsync();
            return Content($"API Kayıt Yapamadı! Hata Kodu: {responseMessage.StatusCode}, Detay: {errorContent}");
        }
    }
}