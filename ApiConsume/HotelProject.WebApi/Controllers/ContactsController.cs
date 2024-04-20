using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.ContactDtos;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetContactList()
        {
            var values = _contactService.TGetList();

            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddContact(CreateContactDto createContactDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Contact>(createContactDto);

            values.Date = Convert.ToDateTime(DateTime.Now.ToString());

            _contactService.TAdd(values);

            return Ok();

        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);

            _contactService.TDelete(value);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            _contactService.TUpdate(Contact);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContactByID(int id)
        {
            var value = _contactService.TGetById(id);

            return Ok(value);
        }
    }
}
