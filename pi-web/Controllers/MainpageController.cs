using Microsoft.AspNetCore.Mvc;

namespace pi_web.Controllers
{
    public class MainpageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
