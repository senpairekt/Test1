using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly DutchContext _context;

        public AppController(IMailService mailService, DutchContext context)
        {
           _mailService= mailService;
            this._context = context;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // send the email
                _mailService.SendMessage("feralsvk456@gmail.com", model.Subject, model.Message);
                ViewBag.UserMessage = "Poslane";
                ModelState.Clear();
            }
            else
            {
                // show the errors 
            }
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "O nas";
            return View();
        }
        public IActionResult Shop()
        {
            var results = from p in _context.Products
                          orderby p.Category
                          select p;
            return View(results.ToList());
        }
    }
}
