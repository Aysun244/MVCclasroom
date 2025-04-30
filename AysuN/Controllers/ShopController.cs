using Microsoft.AspNetCore.Mvc;

namespace AysuN.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
