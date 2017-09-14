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
    public class TransactionsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //// GET: api/Transactions
        //public IQueryable<Transaction> GetTransactions()
        //{
        //    return db.Transactions;
        //}

        // GET: api/Transactions/5
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult GetTransactions(int id)
        {
            var transaction = db.Transactions.Where(t => t.customerId == id);
            if (transaction == null)
            {
                return NotFound();
            }
            var result = new List<decimal>();
            foreach(var t in transaction)
            {
                result.Add(t.Amount);
            }

            return Ok(result);
        }

        //// PUT: api/Transactions/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutTransaction(int id, Transaction transaction)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != transaction.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(transaction).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TransactionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Transactions
        //[ResponseType(typeof(Transaction))]
        //public IHttpActionResult PostTransaction(Transaction transaction)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Transactions.Add(transaction);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = transaction.Id }, transaction);
        //}

        //// DELETE: api/Transactions/5
        //[ResponseType(typeof(Transaction))]
        //public IHttpActionResult DeleteTransaction(int id)
        //{
        //    Transaction transaction = db.Transactions.Find(id);
        //    if (transaction == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Transactions.Remove(transaction);
        //    db.SaveChanges();

        //    return Ok(transaction);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool TransactionExists(int id)
        //{
        //    return db.Transactions.Count(e => e.Id == id) > 0;
        //}
    }
}