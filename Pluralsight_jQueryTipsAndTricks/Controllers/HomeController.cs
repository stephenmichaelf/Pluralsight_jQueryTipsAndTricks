using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pluralsight_jQueryTipsAndTricks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WorkingWithSelectors()
        {
            ViewBag.Message = "Working with selectors.";

            return View();
        }

        public ActionResult CustomSelectorHiddenPanels()
        {
            ViewBag.Message = "Custom selector to find hidden panels.";

            return View();
        }

        public ActionResult DOMManipulationTechniques()
        {
            ViewBag.Message = "DOM Manipulation Techniques.";

            return View();
        }
    }
}
