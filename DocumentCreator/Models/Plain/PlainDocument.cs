using System.Collections.Generic;
using System.Text;
using ICT2106.DocumentCreator.Models.Html;

namespace ICT2106.DocumentCreator.Models.Plain
{
    public class PlainDocument : IDocument
    {
        // the title of the document
        private string title = "";
        
        // the author of the document
        private string author = null;
        
        // the elements making up the body of the document
        private IList<PlainElement> body = new List<PlainElement>();
        
        // constructor
        public PlainDocument()
        {
            // nothing to do
        }
        
        // append an element to the body of the document
        public void AppendToBody(PlainElement elementIn)
        {
            body.Add(elementIn);
        }
        
        // make a deep clone of the document
        public IDocument Clone()
        {
            PlainDocument clone = new PlainDocument();
            clone.SetTitle(title);
            foreach (PlainElement elem in body)
                clone.AppendToBody(elem.Clone());

            return clone;
        }

        public string GetString()
        {
            StringBuilder sbuilder = new StringBuilder();
            sbuilder.Append(new PlainHeading(1, title).GetString());

            sbuilder.Append(new PlainHeading(1, author).GetString());

            // append all of the body elements
            foreach (PlainElement elem in body)
                sbuilder.Append(elem.GetString());

            return sbuilder.ToString();
        }
        
        // set the author of the document
        public void SetAuthor(string authorIn)
        {
            author = authorIn;;
        }
        
        // set the title of the document
        public void SetTitle(string titleIn)
        {
            title = titleIn;
        }
    }
}