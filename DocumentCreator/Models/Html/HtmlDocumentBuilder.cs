//
// ICT2106 Software Design - Document Creator example
//
// HTML document builder.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Html
{
    class HtmlDocumentBuilder : IDocumentBuilder
    {
        private HtmlDocument doc;
        private string title;
        private string author;

        // constructor
        public HtmlDocumentBuilder()
        {
            // nothing to do
        }

        // start building a new document
        public void OpenDocument()
        {
            doc = new HtmlDocument();

            // erase the title and author
            title = "";
            author = "";
        }

        // build the <head> element
        public void BuildHead(string titleIn, string authorIn)
        {
            // save the title and author for later
            title = titleIn;
            author = authorIn;

            // set the title of the document
            doc.SetTitle(titleIn);
        }

        // build the <body> element
        public void BuildBody(string textIn)
        {
            // add a top-level heading containing the title
            doc.AppendToBody(new HtmlHeading(1, title));

            // add a second-level heading containing the author
            doc.AppendToBody(new HtmlHeading(2, "by " + author));

            // add a paragraph containing the text
            doc.AppendToBody(new HtmlParagraph(textIn));
        }

        // finish the document
        public void CloseDocument()
        {
            // nothing to do
        }

        // get the document being built
        public IDocument GetDocument()
        {
            return doc;
        }
    }
}
