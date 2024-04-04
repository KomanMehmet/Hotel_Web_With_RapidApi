using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribesController(ISubscribeService SubscribeSubscribe)
        {
            _subscribeService = SubscribeSubscribe;
        }

        [HttpGet]
        public IActionResult GetSubscribeList()
        {
            var values = _subscribeService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _subscribeService.TAdd(Subscribe);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);

            _subscribeService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _subscribeService.TUpdate(Subscribe);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeByID(int id)
        {
            var value = _subscribeService.TGetById(id);

            return Ok(value);
        }
    }
}
