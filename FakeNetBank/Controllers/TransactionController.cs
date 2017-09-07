using FakeNetBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace FakeNetBank.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Transaction/Deposit
        public ActionResult Deposit(int customerId)
        {
            
            return View();
        }

        // Post: Transaction/Deposit
        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            

            // Chec for valid data
            if (ModelState.IsValid)
            {
                //Deposit onto customer Table
                //var customer = _context.Customers.Find(transaction.customerId);
                var customer = _context.Customers.SingleOrDefault(c => c.Id == transaction.customerId);

                if (customer == null)
                {
                    return View();
                }


                customer.Balance += Math.Abs(transaction.Amount);

                

                // Add Deposit to Transactions Table Log
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }




        // GET: Transaction/Withdraw
        public ActionResult Withdraw(int customerId)
        {

            return View();
        }

        // POST: Transaction/Withdraw
        [HttpPost]
        public ActionResult Withdraw(Transaction transaction)
        {
            


            if (ModelState.IsValid)
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == transaction.customerId);

                customer.Balance -= Math.Abs(transaction.Amount);
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
                        
            return View();
        }
    }
}