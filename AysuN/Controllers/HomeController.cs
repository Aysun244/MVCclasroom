using Microsoft.AspNetCore.Mvc;

namespace AysuN.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
