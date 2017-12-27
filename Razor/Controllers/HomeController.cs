using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product bananas = new Product
            {
                ID = 1,
                name = "Bananas",
                desc = "Nice Bananas",
                price = 1.50M
            };

            ViewBag.qty = 4;
            return View(bananas);
        }

        public IActionResult Collection()
        {
            Product[] prdoucts = 
            {
                new Product { name = "Bannas", price = 1.40M},
                new Product { name = "Apples", price = 1.00M},
                new Product { name = "Oranges", price = 1.20M},
                new Product { name = "Kiwis", price = 1.70M},
            };
            
            return View(prdoucts);
        }
    }
}