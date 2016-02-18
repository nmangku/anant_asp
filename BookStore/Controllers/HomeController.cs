using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {

        private StoreDbContext db = new StoreDbContext();

        // GET: Book
        public ActionResult Index()
        {
            return View(db.books.ToList());
        }

    }
}