using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = "Leroy";
            ViewBag.Greeting = "Hello there";
            ViewBag.Team = "Team Backrow";
            ViewBag.Names = new List<string> { "Lee", "Blair", "Andi", "Josh", "Jennifer" };
            return View("Index");
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
