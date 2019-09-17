using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp2084_lab1.Models;

namespace Comp2084_lab1.Controllers
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

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult Addition(int A  , int B )
        {
            return Ok("Result = "  + (A + B).ToString());
        }

        public ActionResult Multiplication(int A, int B)
        {
            return Ok("Result = " + (A * B).ToString());
        }

        public ActionResult AddMultiply(int A, int B)
        {
            return Ok("Addition Result = " + (A + B).ToString() + "\n" + "Multiplication Result = " + (A * B).ToString());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
