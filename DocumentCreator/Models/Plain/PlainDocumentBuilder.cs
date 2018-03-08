namespace ICT2106.DocumentCreator.Models.Plain
{
    public class PlainDocumentBuilder : IDocumentBuilder
    {
        private PlainDocument doc;
        private string title;
        private string author;

        // constructor
        public PlainDocumentBuilder()
        {
            // nothing to do
        }

        // start building a new document
        public void OpenDocument()
        {
            doc = new PlainDocument();

            // erase the title and author
            title = "";
            author = "";
        }

        // build the header
        public void BuildHead(string titleIn, string authorIn)
        {
            // set the title and author of the document
            doc.SetTitle(titleIn);
            doc.SetAuthor(authorIn);
        }

        // build the <body> element
        public void BuildBody(string textIn)
        {
            // add a paragraph containing the text
            doc.AppendToBody(new PlainParagraph(textIn));
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