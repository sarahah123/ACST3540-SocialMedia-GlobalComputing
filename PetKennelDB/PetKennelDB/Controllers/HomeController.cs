using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetKennelDB.Models;
using System.Net.Mail;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab 10
 */

namespace PetKennelDB.Controllers
{
    public class HomeController : Controller
    {
        public PetKennelDBEntities db = new PetKennelDBEntities();

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Pet Kennel!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the pet kennel:<br /> WebMaster: Sarah Hansberry";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List()
        {
            ViewBag.Message = "Here's the list of the pets at the Kennel:";
            return View(db.Pets);
        }

        public ActionResult Details(int ID)
        {
            ViewBag.Message = "Details of this pet:";
            try
            {
                Pet thePet = db.Pets.First(p => p.ID == ID);
                return View(thePet);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Fill in the details for this pet:";
            return View();
        }

        [HttpPost]
        public ActionResult Create(Pet p)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Message = "Error creating pet:";
                    return View("Create", p);
                }

                db.Pets.Add(p);
                db.SaveChanges();

                MailMessage message = new MailMessage();
                message.From = new MailAddress("CaringStaff@petkennel.com");
                message.To.Add(new MailAddress(p.OwnerEmail));
                message.Subject = "Confirmation of Pet's Arrival";
                message.Body = "Hello owner of " + p.Name + ",";
                message.Body += Environment.NewLine + Environment.NewLine;
                message.Body += "This is to confirm that your Pet has arrived! ";
                message.Body += "Your pet is a " + p.AnimalType + " and your pet's age is " + p.Age + ".";

                SmtpClient client = new SmtpClient();
                client.Host = "208.73.222.114";
                client.Port = 7301;
                client.Send(message);

                return RedirectToAction("List");
            }
            catch
            {
                ViewBag.Message = "Error creating pet:";
                return View("Create", p);
            }
        }

        public ActionResult Edit(int ID)
        {
            ViewBag.Message = "Edit the following Pet's Information:";
            try
            {
                Pet thePet = db.Pets.First(p => p.ID == ID);
                return View(thePet);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Message = "Error editing pet:";
                    return View("Edit", pet);
                }

                Pet thePet = db.Pets.First(p => p.ID == pet.ID);

                thePet.Name = pet.Name;
                thePet.Age = pet.Age;
                thePet.AnimalType = pet.AnimalType;
                thePet.OwnerEmail = pet.OwnerEmail;
                db.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                ViewBag.Message = "Error editing pet:";
                return View("Edit", pet);
            }
        }

        public ActionResult Delete(int ID)
        {
            ViewBag.Message = "Delete the following Pet:";
            try
            {
                Pet thePet = db.Pets.First(p => p.ID == ID);
                return View(thePet);
            }
            catch
            {
                return RedirectToAction("Error");
            }
        }

        [HttpPost]
        public ActionResult Delete(Pet pet)
        {
            try
            {
                if (pet == null)
                    return RedirectToAction("Error");

                Pet thePet = db.Pets.First(p => p.ID == pet.ID);
                db.Pets.Remove(thePet);
                db.SaveChanges();

                return RedirectToAction("List");
            }
            catch
            {
                ViewBag.Message = "Error deleting pet:";
                return View("Delete", pet);
            }
        }
    }
}