using DemoProject.Data;
using DemoProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public ActionResult Login()
        {
            
            return View(new LoginViewModel());
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = _context.Users
                      .FirstOrDefault(u => u.UserName == model.Username && u.Password == model.Password);
            if (user!=null)
            {
                // Redirect to a secure area if login is successful
                return RedirectToAction("Index", "Dashboard");
            }
            // Add error message if login fails
            ModelState.AddModelError("", "Invalid username or password.");
            return View(model);
        }


    }
}
