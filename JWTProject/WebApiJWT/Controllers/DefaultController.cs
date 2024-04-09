using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJWT.Models;

namespace WebApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult Test() 
        {
            return Ok(new CreateToken().GenerateToken());
        }

        [HttpGet("[action]")]
        public ActionResult Test1()
        {
            return Ok(new CreateToken().GenerateTokenToAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles = "Admin, Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Token Başarılı bir şekilde giriş yaptı");
        }
    }
}
