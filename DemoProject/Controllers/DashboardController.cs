using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
