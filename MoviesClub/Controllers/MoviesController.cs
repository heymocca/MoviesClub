using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesClub.Models;

namespace MoviesClub.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);

        }

        public ActionResult Edit(int movieId)
        {
            return Content("movieId=" + movieId);
        }
    }
}