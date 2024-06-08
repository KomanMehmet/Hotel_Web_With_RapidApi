using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.SendMessageDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService SendMessageService, IMapper mapper)
        {
            _sendMessageService = SendMessageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetSendMessageList()
        {
            var values = _sendMessageService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSendMessage(CreateSendMessageDto createSendMessageDto)
        {
            var values = _mapper.Map<SendMessage>(createSendMessageDto);

            _sendMessageService.TAdd(values);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSendMessage(int id)
        {
            var value = _sendMessageService.TGetById(id);

            _sendMessageService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage SendMessage)
        {
            _sendMessageService.TUpdate(SendMessage);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessageByID(int id)
        {
            var value = _sendMessageService.TGetById(id);

            return Ok(value);
        }
    }
}
