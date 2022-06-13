using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTrest.Controllers
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            //throw new Exception("Som Bad things are happenning");
            return View();
            //This is commit from Github
            // The logic here can return multiple things
            // Like redirect to a new page
            // Return view as in this case
            // Return an error etc.....
        }
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
