namespace ICT2106.DocumentCreator.Models.Plain
{
    public class PlainDocumentFactory  : IDocumentFactory
    {
        // constructor
        public PlainDocumentFactory()
        {
            // nothing to do
        }
        
        public IHeading CreateHeading(int level, string text)
        {
            return new PlainHeading(level, text);
        }

        public IParagraph CreateParagraph(string text)
        {
            return new PlainParagraph(text);
        }
    }
}