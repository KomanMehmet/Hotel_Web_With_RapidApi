using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetRoomList()
        {
            var values = _roomService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(CreateRoomDto createRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(createRoomDto);

            _roomService.TAdd(values);

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetById(id);
            
            _roomService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomByID(int id)
        {
            var value = _roomService.TGetById(id);

            return Ok(value);
        }
        
        [HttpGet("GetFirstThreeRooms")]
        public IActionResult GetFirstThreeRooms()
        {
            var values = _roomService.TGetFirstThreeRooms();

            return Ok(values);
        }
    }
}
