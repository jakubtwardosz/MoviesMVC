using Microsoft.AspNetCore.Mvc;
using MoviesMVC.Models;
using System.Reflection;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }

        public IActionResult Show(int Id)
        {
            return View(Repository.Movies.SingleOrDefault(item => item.Id == Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                Repository.addMovie(movie);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            Repository.deleteMovie(Id);
            return RedirectToAction("Index");
        }
    }
}
