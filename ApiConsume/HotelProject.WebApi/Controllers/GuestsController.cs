using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.GuestDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestsController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetGuestList()
        {
            var values = _guestService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddGuest(CreateGuestDto createGuestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Guest>(createGuestDto);

            _guestService.TAdd(values);

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetById(id);

            _guestService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateGuest(Guest Guest)
        {
            _guestService.TUpdate(Guest);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetGuestByID(int id)
        {
            var value = _guestService.TGetById(id);

            return Ok(value);
        }
    }
}
