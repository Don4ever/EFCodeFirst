﻿using System;
using EFCodeFirst.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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

            
        }

        public ActionResult delBlog (int id)
        {
            Blog bg = new Blog();
            bg = db.BlogsTable.Find(id);
            db.BlogsTable.Remove(bg);
            db.SaveChanges();
            return View("Create",db.BlogsTable.ToList());
        }
        public ActionResult Edit(int id)
        {
            Blog bg = new Blog();
            bg = db.BlogsTable.Find(id);
            

            return View(bg);
        }
        [HttpPost]
        public ActionResult Edit(Blog bg)
        {

            db.BlogsTable.Attach(bg);
            db.Entry(bg).State = EntityState.Modified;
            db.SaveChanges();

          //  db.SaveChanges();


            List<Blog> b = db.BlogsTable.ToList();
            return View("Create",b);


           
        }

    }
}