using Microsoft.AspNetCore.Mvc;

namespace Foodordering.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}