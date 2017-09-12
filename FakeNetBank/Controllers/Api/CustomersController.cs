using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FakeNetBank.Models;

namespace FakeNetBank.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: api/Customers/5
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer.Balance.ToString());
        }
         

    }
}
//        // PUT: api/Customers/5
//        [ResponseType(typeof(void))]
//        public IHttpActionResult PutCustomer(int id, Customer customer)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            if (id != customer.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(customer).State = EntityState.Modified;

//            try
//            {
//                _context.SaveChanges();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!CustomerExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return StatusCode(HttpStatusCode.NoContent);
//        }

//        // POST: api/Customers
//        [ResponseType(typeof(Customer))]
//        public IHttpActionResult PostCustomer(Customer customer)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            _context.Customers.Add(customer);
//            _context.SaveChanges();

//            return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
//        }

//        // DELETE: api/Customers/5
//        [ResponseType(typeof(Customer))]
//        public IHttpActionResult DeleteCustomer(int id)
//        {
//            Customer customer = _context.Customers.Find(id);
//            if (customer == null)
//            {
//                return NotFound();
//            }

//            _context.Customers.Remove(customer);
//            _context.SaveChanges();

//            return Ok(customer);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                _context.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private bool CustomerExists(int id)
//        {
//            return _context.Customers.Count(e => e.Id == id) > 0;
//        }
//    }
//}