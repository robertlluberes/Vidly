using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Index
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MoviesFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View("MoviesForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movieInDb = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return HttpNotFound();

            var viewModel = new MoviesFormViewModel(movieInDb)
            {
                Genres = _context.Genres.ToList()
            };


            return View("MoviesForm", viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var genres = _context.Genres.ToList();
                var viewModel = new MoviesFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MoviesForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDB = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDB.Name = movie.Name;
                movieInDB.ReleaseDate = movie.ReleaseDate;
                movieInDB.GenreId = movie.GenreId;
                movieInDB.NumberInStock = movie.NumberInStock;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).Where(m => m.Id == id).FirstOrDefault();

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }
    }
}