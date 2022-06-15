using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetrolProje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PetrolProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(Calculator cal)
        {
            double a, b;
            a = Convert.ToDouble(cal.value1);
            b = Convert.ToDouble(cal.value2);
            if (cal.Calculate == "Calculate")
            {
                cal.Result = (float)((a / b) * 100);
            }
            ViewData["Result"] = cal.Result;
            return View();
        }
        public IActionResult Map()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Prices()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
