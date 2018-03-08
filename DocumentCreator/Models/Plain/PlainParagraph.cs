using System.Text;

namespace ICT2106.DocumentCreator.Models.Plain
{
    class PlainParagraph : PlainElement, IParagraph
    {
        private string text;

        // constructor
        public PlainParagraph(string textIn)
        {
            text = textIn;
        }

        // create a deep clone of the paragraph
        public override PlainElement Clone()
        {
            return new PlainParagraph(text);
        }

        // paragraphs in HTML are plain text followed by blank line"
        public override string GetString()
        {
            StringBuilder para = new StringBuilder(text, text.Length + 5);
            return para.Append("\n\n").ToString();
        }
    }
}