using System;
using EFCodeFirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    public class blogController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            List<Blog> b = db.BlogsTable.ToList();
            return View(b);
        }
        [HttpPost]
        public ActionResult Create(Blog bl)
        {
            db.BlogsTable.Add(bl);
            db.SaveChanges();


            List<Blog> b = db.BlogsTable.ToList();
            return View(b);

            return View();
        }
    }
}