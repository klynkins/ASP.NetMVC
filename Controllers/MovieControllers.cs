using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NetMVC.Models;

namespace ASP.NetMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET : Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" };
            return View(movie);
        }
    }
}