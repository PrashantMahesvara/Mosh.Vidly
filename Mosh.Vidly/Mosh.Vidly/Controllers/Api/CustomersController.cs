using AutoMapper;
using Mosh.Vidly.Dtos;
using Mosh.Vidly.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Mosh.Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _db;

        public CustomersController()
        {
            _db = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _db.Customers.Include(c => c.MembershipType).ToList();
        }

        public Customer GetCustomer(int id)
        {
            var customer = _db.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return customer;
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _db.Customers.Add(customer);
            _db.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customer);
        }

        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _db.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            customerInDb.Name = customer.Name;
            customerInDb.Birthday = customer.Birthday;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;

            _db.SaveChanges();
        }

        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _db.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _db.Customers.Remove(customerInDb);
            _db.SaveChanges();
        }
    }
}
