using Microsoft.AspNetCore.Mvc;

namespace AysuN.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
