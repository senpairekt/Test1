using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
           _mailService= mailService;
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
    }
}
