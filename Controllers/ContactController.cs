using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace anna.Controllers
{
    public class ContactController : Controller
    {
        
        
        public ActionResult Index()
        {
            return View();
        }
      
        [HttpPost]
        public ActionResult SubmitForm(string name, string email, string message)
        {

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Message: {message}");

            return RedirectToAction("Index", "Home");
        }
    }
}