﻿using HotelProject.WebUI.Dtos.BookingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
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
            createBookingDto.Description = "Description";

            var client = _httpClientFactory.CreateClient();

            var jsonData = JsonConvert.SerializeObject(createBookingDto);

            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            await client.PostAsync("http://localhost:5096/api/Bookings", stringContent);

            return RedirectToAction("Index", "Booking");
        }
    }
}
