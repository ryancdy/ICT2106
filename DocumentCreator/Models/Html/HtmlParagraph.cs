//
// ICT2106 Software Design - Document Creator example
//
// HTML paragraph.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Html
{
    class HtmlParagraph : HtmlElement, IParagraph
    {
        private string text;

        // constructor
        public HtmlParagraph(string textIn)
        {
            text = textIn;
        }

        // create a deep clone of the paragraph
        public override HtmlElement Clone()
        {
            return new HtmlParagraph(text);
        }

        // paragraphs in HTML are denoted by "<p>...</p>"
        public override string GetString()
        {
            return "<p>\n" + text + "\n</p>\n\n";
        }
    }
}
