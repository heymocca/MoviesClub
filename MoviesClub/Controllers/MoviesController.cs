﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesClub.Models;

namespace MoviesClub.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name = "Customer 1"},
        //        new Customer {Name = "Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customers
        //    };

        //    return View(viewModel);

        //}

        //[Route("Customers")]
        //public ActionResult Customer()
        //{
        //    //var movies = new List<Movie>
        //    //{
        //    //   new Movie {Name = "The darkest hour"},
        //    //   new Movie {Name = "Come to my world"} 
        //    //};

        //    //var movie = new Movie() { Name = "Shrek!" };



        //    var customers = new List<Customer>
        //    {
        //        new Customer {Name = "James"},
        //        new Customer {Name = "Kelly"}
        //    };

        //    var viewModel = new MovieCustomerViewModels
        //    {
        //        Customers = customers
        //    };

        //    return View(viewModel);
        //}

        //[Route("Movies")]
        //public ActionResult Movie()
        //{
        //    var movies = new List<Movie>
        //    {
        //        new Movie {Name = "Shrek!"},
        //        new Movie {Name = "The darkest hour!"},
        //    };

        //    var viewModel = new MovieCustomerViewModels
        //    {
        //        Movies = movies
        //    };

        //    return View(viewModel);
        //}


        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 2, Name = "Start War"}
            };
        }
    }
}