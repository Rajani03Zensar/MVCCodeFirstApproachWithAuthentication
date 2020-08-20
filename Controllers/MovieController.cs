using MovieCustomerMVCWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCustomerMVCWithAuthentication.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _dbcontext;
        public MovieController()
        {
            _dbcontext = new ApplicationDbContext();
        }
        // GET: Movie
        public ActionResult GetMovies()
        {
            var movies = _dbcontext.Movies.ToList();
            return View(movies);
        }
        public ActionResult Display(int id)
        {
            var singleMovie = _dbcontext.Movies.SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
                return HttpNotFound();
            return View(singleMovie);
        }
        protected override void Dispose(bool disposing)
        {
            _dbcontext.Dispose();
        }
    }
}