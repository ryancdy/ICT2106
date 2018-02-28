//
// ICT2106 Software Design - Document Creator example
//
// Controller demonstrating the Builder pattern.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

using ICT2106.DocumentCreator.Models;


namespace ICT2106.DocumentCreator.Controllers
{
    public class BuilderController : Controller
    {
        //
        // GET: /Builder/
        //
        // Home page for creating documents using the Builder pattern
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
        public IActionResult Submit(string format, string titleText, string authorText, string bodyText)
        {
            // get the proper document builder for the output type
            IDocumentBuilder builder = DocumentCreatorSingleton.GetInstance().GetDocumentBuilder(format);

            // start building
            builder.OpenDocument();

            // build the head with the title and author
            builder.BuildHead(titleText, authorText);

            // build the body 
            builder.BuildBody(bodyText);

            // finished building
            builder.CloseDocument();
            
            return View("~/Views/Shared/Results.cshtml", builder.GetDocument().GetString());
        }
    }
}
