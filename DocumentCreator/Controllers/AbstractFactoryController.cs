//
// ICT2106 Software Design - Document Creator example
//
// Controller demonstrating the Abstract Factory pattern.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

using ICT2106.DocumentCreator.Models;

namespace ICT2106.DocumentCreator.Controllers
{
    public class AbstractFactoryController : Controller
    {
        //
        // GET: /AbstractFactory/
        //
        // Home page for creating documents with the Abstract Factory pattern
        //
        public IActionResult Index(string format)
        {
            // pass the output format as view data to be saved in the form
            ViewData["Format"] = format;

            return View();
        }

        //
        // GET: /AbstractFactory/Submit
        //
        // Process a submission.
        //
        public IActionResult Submit(string format, string headingText, string paragraphText)
        {
            // get the proper document factory for the output type
            IDocumentFactory factory = DocumentCreatorSingleton.GetInstance().GetDocumentFactory(format);

            // create the document parts
            IHeading headingObj = factory.CreateHeading(1, headingText);
            IParagraph paragraphObj = factory.CreateParagraph(paragraphText);
            
            return View("~/Views/Shared/Results.cshtml", headingObj.GetString() + paragraphObj.GetString());
        }
    }
}
