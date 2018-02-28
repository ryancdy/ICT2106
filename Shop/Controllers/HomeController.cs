//
// ICT2106 Software Design - Shop example
//
// Home controller.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

namespace ICT2106.Shop.Controllers
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
        // GET: /Home/About/
        //
        // About page
        //
        public IActionResult About()
        {
            return View();
        }

        //
        // GET: /Home/Error
        //
        // Error page
        //
        public IActionResult Error()
        {
            return View();
        }
    }
}
