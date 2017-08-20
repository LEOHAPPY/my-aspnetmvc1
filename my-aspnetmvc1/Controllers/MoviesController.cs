using my_aspnetmvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace my_aspnetmvc1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Harry Potter"
            };
            return View(movie);
        }

        [Route("movies/release/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(string.Format("this is the year of {0}, the month of {1}", year, month));
        }
    }
}