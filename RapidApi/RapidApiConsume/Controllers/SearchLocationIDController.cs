using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationIDController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if(!string.IsNullOrEmpty(cityName))
            {

                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();

                var client = new HttpClient();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "873f0bbc68msh9489db938af6c5dp16d124jsndb3f964b800f" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();

                    var body = await response.Content.ReadAsStringAsync();

                    bookingApiSearchLocationViewModels = JsonConvert.DeserializeObject<List<BookingApiSearchLocationViewModel>>(body);

                    return View(bookingApiSearchLocationViewModels.Take(1).ToList());
                }
            }
            else
            {

                List<BookingApiSearchLocationViewModel> bookingApiSearchLocationViewModels = new List<BookingApiSearchLocationViewModel>();

                var client = new HttpClient();

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/locations?name=paris&locale=en-gb"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "873f0bbc68msh9489db938af6c5dp16d124jsndb3f964b800f" },
                    { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();

                    var body = await response.Content.ReadAsStringAsync();

                    bookingApiSearchLocationViewModels = JsonConvert.DeserializeObject<List<BookingApiSearchLocationViewModel>>(body);

                    return View(bookingApiSearchLocationViewModels.Take(1).ToList());
                }
            }

        }
    }
}
