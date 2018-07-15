using Mosh.Vidly.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Mosh.Vidly.Controllers
{
    public class CustomersController : Controller
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
            var listOfCustomers = _db.Customers.Include(m => m.MembershipType).ToList();

            return View(listOfCustomers);
        }
    }
}