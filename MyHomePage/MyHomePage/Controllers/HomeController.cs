using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 * Course:          ACST 4550
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Homework1
 */

namespace MyHomePage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "What's your favorite color?";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Sarah";
            //add code to change this color to the one the user entered in the text box, saved in variable 'color'

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}