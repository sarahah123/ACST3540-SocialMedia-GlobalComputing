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
 * Assignment #:    Lab 6
 */

namespace HelloThereMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello There";

            String[] options = { "kitten1", "kitten2", "kitten3" };

            ViewBag.ListItems = new SelectList(options, "SelectedItem");

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            String fullName = form[0];
            String color = form[1];
            String picture = form[2];

            Session["greeting"] = ViewBag.Message = "<span style='color:" + color + ";'>Hello " +fullName + "</span>";


            String[] options = { "kitten1", "kitten2", "kitten3" };

            ViewBag.ListItems = new SelectList(options, "SelectedItem");


            if (picture == "kitten1")
            {
                Session["image"] = ViewBag.Image += "<br /><img src='/image/kitten1.png'>";
            }
            else if (picture == "kitten2")
            {
                Session["image"] = ViewBag.Image += "<br /><img src='/image/kitten2.png'>";
            }
            else
            {
                Session["image"] = ViewBag.Image += "<br /><img src='/image/kitten3.png'>";
            }


            return RedirectToAction("About");
        }
         
        public ActionResult About()
        {
            ViewBag.Message = Session["greeting"];
            ViewBag.Image += Session["image"];

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}