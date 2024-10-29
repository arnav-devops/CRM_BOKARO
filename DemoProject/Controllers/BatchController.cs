using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class BatchController : Controller
    {
        public IActionResult CreateBatch()
        {
            return View();
        }
    }
}
