using Mosh.Vidly.Models;
using Mosh.Vidly.ViewModels.Vidly;
using System.Data;
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
            return View();
        }

        [HttpGet]
        public ViewResult Details(int? id)
        {
            var customer = _db.Customers.Find(id);
            return View(customer);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = _db.Customers.Include(m => m.MembershipType).ToList(),
                MembershipTypes = _db.MembershipTypes.ToList()
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            var viewModel = new CustomerViewModel
            {
                Customers = _db.Customers.Include(m => m.MembershipType).ToList(),
                MembershipTypes = _db.MembershipTypes.ToList()
            };


            try
            {
                if (ModelState.IsValid)
                {
                    _db.Customers.Add(customer);
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
            var customer = _db.Customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _db.MembershipTypes.ToList()
            };

            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _db.MembershipTypes.ToList()
            };

            if (ModelState.IsValid)
            {
                _db.Entry(customer).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        [HttpGet]
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
            var customer = _db.Customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again!";
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var customer = _db.Customers.SingleOrDefault(m => m.Id == id);
                _db.Customers.Remove(customer);
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