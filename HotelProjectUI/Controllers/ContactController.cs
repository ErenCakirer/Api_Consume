using HotelProjectUI.Dtos.BookingDto;
using HotelProjectUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto  createContactDto)
        {

           createContactDto.Date =DateTime.Parse(DateTime.Now.ToShortDateString());
      

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");


            var responseMessage = await client.PostAsync("http://localhost:5027/api/Contact", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index", "Default");
            }


            var errorContent = await responseMessage.Content.ReadAsStringAsync();
            return Content($"API Kayıt Yapamadı! Hata Kodu: {responseMessage.StatusCode}, Detay: {errorContent}");
        }
    }
}
