using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesMVC.Data;
using MoviesMVC.Models;
using System.Reflection;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly DataContext _context;

        public MovieController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Movies.ToList());
        }

        public IActionResult Show(int Id)
        {
            return View(_context.Movies.FirstOrDefault(item => item.Id == Id));
        }

        
        public IActionResult Edit(int Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var movie = _context.Movies.FirstOrDefault(item => item.Id == Id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Genre,Description,ReleaseDate,BoxOffice,Rating")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                    _context.Update(movie);
                    await _context.SaveChangesAsync();
               
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }


        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int Id)
        {
            var movie = _context.Movies.FirstOrDefault(item => item.Id == Id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
