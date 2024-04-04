using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService TestimonialTestimonial)
        {
            _testimonialService = TestimonialTestimonial;
        }

        [HttpGet]
        public IActionResult GetTestimonialList()
        {
            var values = _testimonialService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial Testimonial)
        {
            _testimonialService.TAdd(Testimonial);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);

            _testimonialService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _testimonialService.TUpdate(Testimonial);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonialByID(int id)
        {
            var value = _testimonialService.TGetById(id);

            return Ok(value);
        }
    }
}
