using HotelProject.WebUI.Dtos.GuestDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class GuestController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GuestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5096/api/Guests");

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsonData);

                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateGuest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateGuest(CreateGuestDto createGuestDto)
        {
            if(ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();

                var jsonData = JsonConvert.SerializeObject(createGuestDto);

                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var responseMessage = await client.PostAsync("http://localhost:5096/api/Guests", stringContent);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return View();
            }
            else
            {
                return View();
            }
            
        }

        public async Task<IActionResult> DeleteGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.DeleteAsync($"http://localhost:5096/api/Guests?id={id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateGuest(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync($"http://localhost:5096/api/Guests/{id}");

            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);

                return View(value);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDto updateGuestDto)
        {
            if(ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();

                var jsonData = JsonConvert.SerializeObject(updateGuestDto);

                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var responseMessage = await client.PutAsync("http://localhost:5096/api/Guests", content);

                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return View();
            }
            else
            {
                return View();
            }
            
        }
    }
}
