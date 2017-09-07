using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using FakeNetBank.Models;

namespace FakeNetBank.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var customerId = _context.Customers.Where(c => c.ApplicationUserId == userId).First().Id;
            ViewBag.CustomerId = customerId;
            return View();
        }


    }
}