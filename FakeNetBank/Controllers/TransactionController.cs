using FakeNetBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                _context.Transactions.Add(transaction);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}