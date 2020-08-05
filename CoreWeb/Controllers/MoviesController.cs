using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.ViewModel;
using CoreWebService;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CoreWeb.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _movieServie;
        //private readonly IActorService _actorService;

        public MoviesController( IMoviesService moviesService)
        {
            _movieServie = moviesService;
            //_actorService = actorService;
        }

        public async Task<IActionResult> Index(string movieGenre, string searchString)
        {
            if (this.TempData.ContainsKey("StateError"))
            {
                ViewData["StateError"] = TempData["StateError"];
            }

            try
            {
                IQueryable<string> genreQuery = _movieServie.Get().Select(c => c.Genre).Distinct();
                //IQueryable<Movie> movies = _context.Movies;
                IQueryable<Movie> movies = _movieServie.GetParam(movieGenre, searchString);

                var movieGenreVM = new MovieGenreViewModel()
                {
                    Genres = new SelectList(await genreQuery.ToListAsync()),
                    Movies = await movies.ToListAsync()
                };

                return View(movieGenreVM);
            }
            catch(Exception ex)
            {
                return Content(ex.Message.ToString());
            }
            
            //return View(await _context.Movies.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _movieServie.GetById(id.Value);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _movieServie.GetById(id.Value);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Create()
        {
            Movie movie = new Movie();
            movie.ReleaseDate = DateTime.Now;
            movie.Price = 250;
            return View(movie);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed(Movie movie)
        {
            Dictionary<string, string[]> ModelStateErrors = new Dictionary<string, string[]>();

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Add(movie);
                    _movieServie.Add(movie);
                    await _movieServie.Save();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    return Content(ex.Message.ToString());
                }
            }
            else
            {
                ModelStateErrors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray());
            }

            TempData["StateError"] = ModelStateErrors;
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(movie);
                    //await _context.SaveChangesAsync();
                    _movieServie.Update(movie);
                    await _movieServie.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                    //return RedirectToAction(nameof(Index));
                }
            }
            return View(movie);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            Movie movie = await _movieServie.GetById(id.Value);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var movie = await _context.Movies.FindAsync(id);
            //_context.Movies.Remove(movie);
            //await _context.SaveChangesAsync();
            Movie movie = await _movieServie.GetById(id);
            _movieServie.Remove(movie);
            await _movieServie.Save();

            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _movieServie.Get().Any(x => x.Id == id);
            //return _context.Movies.Any(e => e.Id == id);
        }
    }
}
