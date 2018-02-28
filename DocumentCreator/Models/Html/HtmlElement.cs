//
// ICT2106 Software Design - Document Creator example
//
// Base class for all HTML elements.
//
// Author: Nicholas Sheppard

namespace ICT2106.DocumentCreator.Models.Html
{
    public abstract class HtmlElement
    {
        // create a deep clone of the element
        public abstract HtmlElement Clone();

        // get a string representing the element
        public abstract string GetString();
    }
}
