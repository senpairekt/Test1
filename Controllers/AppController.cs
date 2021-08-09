using Microsoft.AspNetCore.Mvc;
using System;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Kontakt";

            throw new InvalidOperationException("Bad things happen");

            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "O nas";
            return View();
        }
    }
}
