using HotelProject.WebUI.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5096/api/Bookings");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var value = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);

                return View(value);
            }

            return View();
        }


        public async Task<IActionResult> ApprovedBooking(int id)
        {
            var client = _httpClientFactory.CreateClient();

            await client.GetAsync($"http://localhost:5096/api/Bookings/ChangeBookingStatusApproved?id={id}");

            return RedirectToAction("Index");
        }

        
    }
}
