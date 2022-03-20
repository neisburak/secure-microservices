using Microsoft.AspNetCore.Mvc;
using Movies.Client.Models;
using Movies.Client.Services.Interfaces;

namespace Movies.Client.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieApiService _movieService;

        public MoviesController(IMovieApiService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _movieService.Get());
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Genre,ReleaseDate,Owner")] Movie movie)
        {
            return View();

            //if (ModelState.IsValid)
            //{
            //    _context.Add(movie);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //return View(movie);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Genre,ReleaseDate,Owner")] Movie movie)
        {
            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return View();
        }
    }
}