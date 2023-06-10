using Microsoft.AspNetCore.Mvc;

namespace AllupFtoB.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
