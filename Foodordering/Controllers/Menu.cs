using Microsoft.AspNetCore.Mvc;

namespace Foodordering.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}