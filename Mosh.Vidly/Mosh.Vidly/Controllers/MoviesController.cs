using Mosh.Vidly.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Mosh.Vidly.ViewModels.Vidly;
using System.Data;
using System.Net;

namespace Mosh.Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _db.Dispose();
        }

        [HttpGet]
        public ViewResult Index()
        {
            var listOfMovies = _db.Movies.Include(g => g.Genre).ToList();

            return View(listOfMovies);
        }

        public ViewResult Details(int id)
        {
            var movie = _db.Movies.FirstOrDefault();

            return View(movie);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new MovieViewModel
            {
                Movies = _db.Movies.Include(g => g.Genre).ToList(),
                Genres = _db.Genres.ToList()
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            var viewModel = new MovieViewModel
            {
                Movies = _db.Movies.Include(g => g.Genre).ToList(),
                Genres = _db.Genres.ToList()
            };

            try
            {
                if (ModelState.IsValid)
                {
                    _db.Movies.Add(movie);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "unable to save changes");
            }
            return View("Create", viewModel);
        }


        public ActionResult Edit(int id)
        {
            var movie = _db.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Genres = _db.Genres.ToList()
            };

            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Genres = _db.Genres.ToList()
            };

            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        [HttpGet]
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
             Movie movie = _db.Movies.Find(id);

            if (movie == null)
                return HttpNotFound();

            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again!";
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Movie movie = _db.Movies.Find(id);
                _db.Movies.Remove(movie);
                _db.SaveChanges();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            return RedirectToAction("Index");
        }
    }
}