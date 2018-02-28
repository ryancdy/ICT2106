//
// ICT2106 Software Design - Document Creator example
//
// HTML document.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;
using System.Text;

namespace ICT2106.DocumentCreator.Models.Html
{
    public class HtmlDocument : IDocument
    {
        // the title of the document
        private string title = "";

        // the elements making up the body of the document
        private IList<HtmlElement> body = new List<HtmlElement>();


        // constructor
        public HtmlDocument()
        {
            // nothing to do
        }


        // append an element to the body of the document
        public void AppendToBody(HtmlElement elementIn)
        {
            body.Add(elementIn);
        }

        // make a deep clone of the document
        public IDocument Clone()
        {
            HtmlDocument clone = new HtmlDocument();
            clone.SetTitle(title);
            foreach (HtmlElement elem in body)
                clone.AppendToBody(elem.Clone());

            return clone;
        }


        // get a string representing the document
        public string GetString()
        {
            StringBuilder sbuilder = new StringBuilder();

            // start with the <html> element
            sbuilder.Append("<html>\n\n");

            // add the <head> with the <title>
            sbuilder.Append("<head>\n");
            sbuilder.Append("    <title>" + title + "</title>\n");
            sbuilder.Append("</head>\n\n");

            // start the body
            sbuilder.Append("<body>\n\n");

            // append all of the body elements
            foreach (HtmlElement elem in body)
                sbuilder.Append(elem.GetString());

            // finish the body
            sbuilder.Append("</body>\n\n");

            // close the <html> element
            sbuilder.Append("</html>");

            return sbuilder.ToString();
        }


        // set the title of the document
        public void SetTitle(string titleIn)
        {
            title = titleIn;
        }
    }
}
