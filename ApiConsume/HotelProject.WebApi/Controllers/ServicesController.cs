using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService ServiceService)
        {
            _serviceService = ServiceService;
        }

        [HttpGet]
        public IActionResult GetServiceList()
        {
            var values = _serviceService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _serviceService.TAdd(Service);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);

            _serviceService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _serviceService.TUpdate(Service);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetServiceByID(int id)
        {
            var value = _serviceService.TGetById(id);

            return Ok(value);
        }
    }
}
