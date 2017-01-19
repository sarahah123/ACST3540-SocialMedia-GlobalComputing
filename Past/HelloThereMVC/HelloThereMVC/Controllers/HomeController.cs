using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab 2
 */

namespace HelloThereMVC.Controllers
{
    public class HomeController : Controller
    {

        //New Code

        public ActionResult Index()
        {
            ViewBag.Message = "Hello There";
            return View();
        }

        [HttpPost]
        public ActionResult Index(String username)
        {
            // Add code to make the program say hello to username
            ViewBag.Message = "Hello " + username;

            return View();
        }

        //New Code ends

        public ActionResult About()
        {
            ViewBag.Message = "About HelloThereMVC";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}