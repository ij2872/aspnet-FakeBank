using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FakeNetBank.Models;
using Microsoft.AspNet.Identity;

namespace FakeNetBank.Controllers
{
    public class CheckingAccountController : Controller
    {
        //Db
        private ApplicationDbContext _context;

        public CheckingAccountController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: CheckingAccount
        public ActionResult Index()
        {
            return RedirectToAction("Details", "CheckingAccount");
        }


        // GET: CheckingAccount/Details/
        public ActionResult Details()
        {
            var userId = User.Identity.GetUserId();
            var customer = _context.Customers.SingleOrDefault(c => c.ApplicationUserId == userId);

            return View(customer);
        }


        // Get: CheckingAccount/Deposit
        public ActionResult Deposit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }


            return View(customer);
        }

        // POST: CheckingAccount/Deposit
        [HttpPost]
        [ActionName("Deposit")]
        public ActionResult DepositPost()
        {

            return View();
        }








    }
}
