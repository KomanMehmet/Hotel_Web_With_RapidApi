using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _OurTeamComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
