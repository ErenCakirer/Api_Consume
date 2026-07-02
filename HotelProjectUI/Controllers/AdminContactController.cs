using HotelProjectUI.Dtos.ContactDto;
using HotelProjectUI.Dtos.SendMessageDto;
using HotelProjectUI.Models.Staff;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectUI.Controllers
{
    [AllowAnonymous]
    [Route("AdminContact/[action]/{id?}")]
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5027/api/Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);

                var responseMessage2 = await client.GetAsync("http://localhost:5027/api/Contact/GetContactCount");
                if (responseMessage2.IsSuccessStatusCode)
                {
                    var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                    ViewBag.contactCount = jsonData2;
                }
                else
                {
                    ViewBag.contactCount = "0"; 
                }

                var responseMessage3 = await client.GetAsync("http://localhost:5027/api/SendMessage/GetSendMessageCount");
                if (responseMessage3.IsSuccessStatusCode)
                {
                    var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
                    ViewBag.SendMCount = jsonData3;
                }
                else
                {
                    ViewBag.SendMCount = "0"; 
                }

                return View(values);
            }

            return View();
        }


        public async Task<IActionResult> Sendbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/SendMessage");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SendBoxDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessage createSendMessage)
        {
            createSendMessage.SenderMail = "admin@gmail.com";
            createSendMessage.SenderName = "Admin / Resepsiyon";
            createSendMessage.Date = DateTime.Now;

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSendMessage);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("http://localhost:5027/api/SendMessage", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }

            return View();
        }

        public PartialViewResult SidebarContactP()
        {
            return PartialView();
        }

        public PartialViewResult SidebarContactCategoryP()
        {
            return PartialView();
        }
        public async Task<IActionResult> MessageDetailsByInbox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/Contact");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var allMessages = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);

                var values = allMessages.FirstOrDefault(x => x.ContactID == id);
                if (values != null)
                {
                    return View(values); 
                }
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsBySendBox(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/SendMessage");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var allMessages = JsonConvert.DeserializeObject<List<SendBoxDto>>(jsonData);

                var values = allMessages.FirstOrDefault(x => x.SendMessageID == id);
                if (values != null)
                {
                    return View(values); 
                }
            }
            return View();
        }
        public async Task<IActionResult> GetContactCount()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5027/api/Contact/GetContactCount");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
    }
    
