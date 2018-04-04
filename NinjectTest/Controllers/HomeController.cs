using Ninject;
using NinjectTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly Entities _entities;

        public HomeController(Entities entities)
        {
            _entities = entities;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}