using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.AboutDtos;
using HotelProject.DtoLayer.Dtos.RoomDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetRoomList()
        {
            var values = _aboutService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAbout(CreateAboutDto createAboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<About>(createAboutDto);

            _aboutService.TAdd(values);

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);

            _aboutService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutByID(int id)
        {
            var value = _aboutService.TGetById(id);

            return Ok(value);
        }
    }
}
