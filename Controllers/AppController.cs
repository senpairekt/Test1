﻿using DutchTreat.ViewModels;
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
            

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)

            {
                // send the email
             
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
