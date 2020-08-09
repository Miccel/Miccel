using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Miccel.Models;
using Miccel.ViewModels;

namespace Miccel.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Movies/Random
        //La ViewResult server per differenziare dall'Action Result in quanto 
        //ha il solo compito di mostrare una view
        public ActionResult Random()
        {
            var movies = new List<Movie>
            {
                new Movie() { Name = "Deadpool" },
                new Movie() { Name = "Il cavaliere oscuro" },
            };
            //return View(movie);
            //return Content("<p>Ciao Mondo!</p>");
            //return HttpNotFound();
            //return null;

            var customers = new List<Customer>
            {
                new Customer{Name = "Michele"},
                new Customer{Name = "Antani"},
            };

            var randomViewModel = new RandomMoviesViewModel
            {
                Movies = movies,
                Customers = customers
            };

            return View(randomViewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie() {Id= 1, Name = "Deadpool" },
                new Movie() {Id= 2, Name = "Il cavaliere oscuro" },
            };



            var viewModel = new RandomMoviesViewModel
            {
                Movies = movies,
                Customers = null,
            };

            return View(viewModel);
        }

        [Route("movies/{id:range(1,2)}")]
        public ActionResult Index(int id)
        {
            var movies = new List<Movie>
            {
                new Movie() {Id= 1, Name = "Deadpool" },
                new Movie() {Id= 2, Name = "Il cavaliere oscuro" },
            };

            movies.RemoveAll(c => c.Id != id);

            var viewModel = new RandomMoviesViewModel
            {
                Movies = movies,
                Customers = null,
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ReleaseByDate(int year, int month)
        {

            var result = String.Format("{0}/{1}", year, month);
            return Content(result);
        }

    }
}