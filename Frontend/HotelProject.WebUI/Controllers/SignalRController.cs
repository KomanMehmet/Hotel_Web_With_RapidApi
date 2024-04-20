using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
