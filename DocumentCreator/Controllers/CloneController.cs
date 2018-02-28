//
// ICT2106 Software Design - Document Creator example
//
// Controller demonstrating the Clone pattern.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

using ICT2106.DocumentCreator.Models;

namespace ICT2106.DocumentCreator.Controllers
{
    public class CloneController : Controller
    {
        //
        // GET: /Clone/
        //
        // Home page for documents created using the Clone pattern
        //
        public IActionResult Index(string format)
        {
            // get a document that can be cloned (in a real program, this document would be passed to us by someone else)
            IDocument doc = DocumentCreatorSingleton.GetInstance().GetSampleDocument(format);

            // make a clone
            IDocument clone = doc.Clone();

            return View("~/Views/Shared/Results.cshtml", clone.GetString());
        }
    }
}
