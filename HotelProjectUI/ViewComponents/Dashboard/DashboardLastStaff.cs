using HotelProjectUI.Dtos.GuestDto;
using HotelProjectUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class DashboardLastStaff:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardLastStaff(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/Staff/LastStaff");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLastStaffDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
