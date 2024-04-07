using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _OurServicesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
