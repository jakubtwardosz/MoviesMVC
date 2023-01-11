using Microsoft.AspNetCore.Mvc;
using MoviesMVC.Models;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }

        public IActionResult Show()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
