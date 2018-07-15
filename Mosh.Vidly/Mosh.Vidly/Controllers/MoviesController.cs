using Mosh.Vidly.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

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
    }
}