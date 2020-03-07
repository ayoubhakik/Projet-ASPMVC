using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projetASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Current = "home";
            ViewData["title"] = "Home";
            return View();
        }

        public ActionResult ChargerLesDonnes()
        {
            ViewBag.Current = "ChargerLesDonnes";
            ViewData["title"] = "Charger Les Donnes";

            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Statistiques()
        {
            return View();
        }
    }
}