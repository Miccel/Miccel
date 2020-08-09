using Miccel.Context;
using Miccel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miccel.Controllers
{
    public class CustomersController : Controller
    {

        private MovieDBContext _context;
        // GET: Customers

        public CustomersController()
        {
            _context = new MovieDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var customers = _context.Customer.ToList();

            return View(customers);
        }

        [Route("customers/{id}")]
        public ActionResult Details(int id)
        {

            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer>GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "Michele"},
                new Customer{Id = 2,Name = "Antani"},
            };
        }

    }
}