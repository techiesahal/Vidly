﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    //public class MoviesController : Controller
    //{

    //    // movies
    //    public ActionResult Index()
    //    {
    //        var movies = new List<Movie>
    //        {
    //            new Movie {Name = "Shrek!"},
    //            new Movie {Name = "Wall-e"}
    //        };

    //        var viewModel = new ListMovieViewModel
    //        {
    //            movies = movies
    //        };


    //        return View(viewModel);
    //    }


    //}

    public class MoviesController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }


        // GET: Movies/Details/1
        public ActionResult Details(int id)
        {

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return Content("There is no movie with such an id: " + id);

            return View(movie);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // New Movie Action
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new NewMovieViewModel
            {
                Genres = genres
            };

            return View(viewModel);
        }


        //Create Action
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            movie.DateAdded = DateTime.Now;

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }

}