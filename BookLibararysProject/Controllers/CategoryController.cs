using Microsoft.AspNetCore.Mvc;

namespace BookLibarary.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
