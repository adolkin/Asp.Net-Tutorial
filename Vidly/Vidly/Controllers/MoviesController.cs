using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Sherk"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy )
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        //}

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Sherk"},
                new Movie {Id = 2, Name = "Wall-E"}
            };
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleashDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}