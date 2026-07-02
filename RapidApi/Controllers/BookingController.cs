using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static RapidApi.Models.BookingHotelViewModel; // Sınıflarına doğrudan erişsin

namespace RapidApi.Controllers
{
    public class BookingController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                // 🎯 BURASI DÜZELTİLDİ: Siteden aldığın tüm çocuk, oda ve amsterdam parametrelerini içeren orijinal URL konuldu!
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?children_ages=5%2C0&adults_number=2&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0&dest_type=city&children_number=2&order_by=popularity&filter_by_currency=EUR&room_number=1&units=metric&checkin_date=2026-06-20&dest_id=-553173&locale=tr&checkout_date=2026-06-21&include_adjacency=true"),
                Headers =
                {
                    { "x-rapidapi-key", "4014387bcemsh503a153922d7db4p18a8c4jsn158f53c6cb41" },
                    { "x-rapidapi-host", "booking-com.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();

                    // Senin Special Paste ile ürettiğin Rootobject modeline datayı çözüyoruz
                    var values = JsonConvert.DeserializeObject<Rootobject>(body);

                    // View katmanına otellerin listesini (results) basması için gönderiyoruz
                    return View(values.results);
                }

                return Content($"Hata Oluştu: {response.StatusCode}");
            }
        }
    }
}