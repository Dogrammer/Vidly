using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private readonly ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Movies/GetAllMovies")]
        public ActionResult GetAllMovies()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        [Route("Movies/Detail/{id}")]
        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(x => x.Id == id);
            return View(movie);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //provjeri jesu li zadani ulazni parametri
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult New()
        {
            var genres= _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {

                Genres = genres

            };

            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
            }

            _context.SaveChanges();

            return RedirectToAction("GetAllMovies", "Movies");
        }

        


    }
}