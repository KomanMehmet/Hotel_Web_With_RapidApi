using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult GetStaffList()
        {
            var values = _staffService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TAdd(staff);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.TGetById(id);

            _staffService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetStaffByID(int id)
        {
            var value = _staffService.TGetById(id);

            return Ok(value);
        }
    }
}
