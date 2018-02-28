//
// ICT2106 Software Design - Document Creator example
//
// HTML document factory
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Html
{
    class HtmlDocumentFactory : IDocumentFactory
    {
        // constructor
        public HtmlDocumentFactory()
        {
            // nothing to do
        }

        // create a heading
        public IHeading CreateHeading(int level, string text)
        {
            return new HtmlHeading(level, text);
        }

        // create a paragraph
        public IParagraph CreateParagraph(string text)
        {
            return new HtmlParagraph(text);
        }
    }
}
