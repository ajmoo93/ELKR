using DataBaseProjekt.Interfaces;
using DataBaseProjekt.Repository;
using ProjectTesting2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectTesting2.Controllers
{
    public class MovieController : Controller
    {
        private readonly IRepository repo;
        // GET: Movie
        public MovieController()
        {
            repo = new Repository();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateMovie(MovieViewModel movies)
        {
            
            return View();
        }
        public ActionResult EditMovie()
        {
            return View();
        }
        public ActionResult DeleteMovie()
        {
            return View();
        }
    }
}