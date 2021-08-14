using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public AppController (IMailService kkt,ILogger<AppController> logger) 
        {
            blab = kkt;
            this.logger = logger;
        }


        private IMailService blab;
        private readonly ILogger logger;

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
                blab.SendMessage("feralsvk456@gmail.com", model.Subject, model.Message);
                logger.LogInformation("jkkjh");
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
