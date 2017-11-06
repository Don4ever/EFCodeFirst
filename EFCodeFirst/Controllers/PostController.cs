using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirst.Controllers
{
    
    public class PostController : Controller
    {
        private BlogContext db = new BlogContext();
        // GET: Post
        public ActionResult Index()
        {
            List<Post> lstPs = db.PostsTable.ToList();
            return View(lstPs);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}