using Microsoft.AspNetCore.Mvc;

namespace Foodordering.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            return View();   // This must match the view name
        }
    }
}