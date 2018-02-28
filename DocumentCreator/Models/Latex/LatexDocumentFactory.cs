//
// ICT2106 Software Design - Document Creator example
//
// LaTeX document factory.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Latex
{
    class LatexDocumentFactory : IDocumentFactory
    {
        // constructor
        public LatexDocumentFactory()
        {
            // nothing to do
        }

        // create a heading
        public IHeading CreateHeading(int level, string text)
        {
            return new LatexHeading(level, text);
        }

        // create a paragraph
        public IParagraph CreateParagraph(string text)
        {
            return new LatexParagraph(text);
        }
    }
}
