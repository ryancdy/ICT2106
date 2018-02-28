//
// ICT2106 Software Design - Document Creator example
//
// Home controller.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ICT2106.DocumentCreator.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //
        // Home page
        //
        public IActionResult Index()
        {
            return View();
        }


        //
        // GET: /Home/Submit/
        //
        // Process submission of the form on the home page
        //
        public IActionResult Submit(string pattern, string format)
        {
            // put parameters to be redirected into a route value dictionary
            RouteValueDictionary parameters = new RouteValueDictionary();
            parameters.Add("format", format);

            // redirect to the controller that handles the method
            switch (pattern)
            {
                case "factory":
                    // use the Abstract Factory pattern
                    return RedirectToAction("Index", "AbstractFactory", parameters);

                case "builder":
                    // use the Builder pattern
                    return RedirectToAction("Index", "Builder", parameters);

                case "clone":
                    // use the Clone pattern
                    return RedirectToAction("Index", "Clone", parameters);

                default:
                    // unrecognised method; return to the blank form
                    return RedirectToAction("Index");
            }

        }


        //
        // About page
        //
        public IActionResult About()
        {
            return View();
        }
    }
}
