using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller // The Essence of MVC. This is the C for controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel(); // The controller builds the model
            model.Name = name ?? "no name";
            model.Message = ConfigurationManager.AppSettings["message"]; // Model with this message from the global.config file
            return View(model); // The controller chooses this Razor view (Index under the Views folder) to render, passes it the model, and returns it to the web browser
        }
    }
}