using System.Text;

namespace ICT2106.DocumentCreator.Models.Plain
{
    public class PlainHeading : PlainElement, IHeading
    {
        private int level;
        private string text;

        // constructor
        public PlainHeading(int levelIn, string textIn)
        {
            level = levelIn;
            text = textIn;
        }

        // create a deep clone of the heading
        public override PlainElement Clone()
        {
            return new PlainHeading(level, text);
        }

        // headings in Plain are all caps followed by blank line
        public override string GetString()
        {
            StringBuilder heading = new StringBuilder(text.ToUpper(), text.Length + 5);
            return heading.Append("\n\n").ToString();
        }

        public int GetLevel()
        {
            throw new System.NotImplementedException();
        }
    }
}