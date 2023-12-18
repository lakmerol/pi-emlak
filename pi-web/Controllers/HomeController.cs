using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace pi_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignIn(string LoginControl)
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginControl(string LoginControl)
        {
            return View();
        }
    }
}