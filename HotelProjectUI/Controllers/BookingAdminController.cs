using HotelProjectUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace HotelProjectUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/Booking");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        [Route("BookingAdmin/ApproveReservation/{id}")]
        [Route("BookingAdmin/ApprovedReservation/{id}")]
        public async Task<IActionResult> ApprovedReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.PutAsync($"http://localhost:5027/api/Booking/ApprovedReservation/{id}",
                new StringContent(string.Empty, Encoding.UTF8, "application/json"));

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "BookingAdmin");
            }

            return Content("Rezervasyon onaylanırken API tarafında bir hata oluştu şef.");
        }

        [HttpGet]
        [Route("BookingAdmin/CancelReservation/{id}")]
        public async Task<IActionResult> CancelReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.PutAsync($"http://localhost:5027/api/Booking/CancelReservation/{id}",
                new StringContent(string.Empty, Encoding.UTF8, "application/json"));

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "BookingAdmin");
            }

            return Content("Rezervasyon iptal edilirken API tarafında bir hata oluştu şef.");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"http://localhost:5027/api/Booking/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);

                return View(values);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PutAsync("http://localhost:5027/api/Booking/", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(updateBookingDto);
        }
    }
}