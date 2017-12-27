using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcCoreOverview.Models;

namespace mvcCoreOverview.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult AnotherAction()
        {
            return View();
        }

        public IActionResult AnotherView()
        {
            return View("SomeView");
        }

        public IActionResult ViewWithParamether()
        {
            string someString = "Pippo Baudo";
            return View("ViewWithParamether", someString);
        }

        public IActionResult PassingData()
        {
            ViewBag.fruit = "Apple";
            ViewData["Color"] = "Red";
            TempData["Number"] = 5;
            return View();
        }

        public IActionResult QueryString(string name, string lastname)
        {
            ViewBag.name = name;
            ViewBag.lastname = lastname;

            return View();
        }
        
        public IActionResult Redirect()
        {
            return Redirect("http://www.google.com");
        }

    }
}
