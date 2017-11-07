using System;
using System.Collections.Generic;
using System.Linq;
using EFCodeFirst.Models;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class authorController : Controller
    {
        // GET: author
        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View(db.AuthorsTable.ToList());
        }
        public ActionResult Create ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Author auth)
        {
            db.AuthorsTable.Add(auth);
            db.SaveChanges();
            return View("Index", db.AuthorsTable.ToList());
        }
    }
}