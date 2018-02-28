//
// ICT2106 Software Design - Document Creator example
//
// Latex document builder.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Latex
{
    public class LatexDocumentBuilder : IDocumentBuilder
    {
        // the document being built
        private LatexDocument doc;

        // constructor
        public LatexDocumentBuilder()
        {
            // nothing to do
        }

        // start building a new document
        public void OpenDocument()
        {
            doc = new LatexDocument();
        }

        // build the header
        public void BuildHead(string titleIn, string authorIn)
        {
            // set the title and author of the document
            doc.SetTitle(titleIn);
            doc.SetAuthor(authorIn);
        }

        // build the body
        public void BuildBody(string textIn)
        {
            // add a paragraph containing the text
            doc.Append(new LatexParagraph(textIn));
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
