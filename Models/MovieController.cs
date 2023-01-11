using Microsoft.AspNetCore.Mvc;

namespace MoviesMVC.Models
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
