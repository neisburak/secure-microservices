using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Client.Models;
using Movies.Client.Services.Interfaces;

namespace Movies.Client.Controllers
{
    [Authorize]
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

        public IActionResult Details(int? id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Genre,ReleaseDate,Owner")] Movie movie)
        {
            return View(movie);
        }

        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Genre,ReleaseDate,Owner")] Movie movie)
        {
            return View(movie);
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            return View();
        }
    }
}