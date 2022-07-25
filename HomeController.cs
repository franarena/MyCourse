using Microsoft.AspNetCore.Mvc;

namespace MyCourse
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono l'index della Home");
        }
    }
}