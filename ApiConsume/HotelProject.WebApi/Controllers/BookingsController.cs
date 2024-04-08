using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.BookingDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingsController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBookingList()
        {
            var values = _bookingService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(CreateBookingDto createBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Booking>(createBookingDto);

            _bookingService.TAdd(values);

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);

            _bookingService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBookingByID(int id)
        {
            var value = _bookingService.TGetById(id);

            return Ok(value);
        }

        [HttpGet("ChangeBookingStatusApproved")]
        public IActionResult ChangeBookingStatusApproved(int id)
        {
            _bookingService.TChangeBookingStatusApproved(id);

            return Ok("Status değiştirildi");
        }

    }
}
