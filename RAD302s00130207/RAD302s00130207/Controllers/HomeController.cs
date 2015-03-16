using RAD302s00130207.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RAD302s00130207.Controllers
{
    
    public class HomeController : Controller
    {
        public nwEntitites db = new nwEntitites();
        private MovieDb dbMovie = new MovieDb();

    
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //dbBlog.Blogs.ToList();
            return View(dbMovie.Movies);

             //return View(db.Orders);
             
        }
    }
}
