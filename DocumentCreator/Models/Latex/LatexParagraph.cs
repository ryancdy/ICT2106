//
// ICT2106 Software Design - Document Creator example
//
// LaTeX paragraph.
//
// Abstract Factory pattern, by Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Latex
{
    class LatexParagraph : LatexElement, IParagraph
    {
        private string text;

        // constructor
        public LatexParagraph(string textIn)
        {
            text = textIn;
        }

        // create a deep clone of the heading
        public override LatexElement Clone()
        {
            return new LatexParagraph(text);
        }

        // LaTeX paragraphs are denoted by empty lines
        public override string GetString()
        {
            return text + "\n\n";
        }
    }
}
