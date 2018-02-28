//
// ICT2106 Software Design - Document Creator example
//
// LaTeX document.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;
using System.Text;

namespace ICT2106.DocumentCreator.Models.Latex
{
    public class LatexDocument : IDocument
    {
        // the title of the document
        private string title = null;

        // the author of the document
        private string author = null;

        // the elements making up the body of the document
        private IList<LatexElement> body = new List<LatexElement>();

        // constructor
        public LatexDocument()
        {
            // nothing to do
        }


        // append an element to the body of the document
        public void Append(LatexElement elementIn)
        {
            body.Add(elementIn);
        }


        // make a deep clone of the document
        public IDocument Clone()
        {
            LatexDocument clone = new LatexDocument();
            clone.SetTitle(title);
            clone.SetAuthor(author);
            foreach (LatexElement elem in body)
                clone.Append(elem.Clone());

            return clone;
        }


        // get a string containing the document
        public string GetString()
        {
            // create a new string containing the document
            StringBuilder sbuilder = new StringBuilder();

            // start with the \documentclass declaration
            sbuilder.Append("\\documentclass{article}\n\n");

            // add the title and author
            if (title != null)
                sbuilder.Append("\\title{" + title + "}\n");
            if (author != null)
                sbuilder.Append("\\author{" + author + "}\n");
            sbuilder.Append("\n");

            // start the document body
            sbuilder.Append("\\begin{document}\n");

            // render the title and author, if they exist
            if (title != null || author != null)
                sbuilder.Append("\\maketitle\n");
            sbuilder.Append("\n");

            // append the body elements
            foreach (LatexElement elem in body)
                sbuilder.Append(elem.GetString());

            // end the document
            sbuilder.Append("\\end{document}");

            return sbuilder.ToString();
        }


        // set the author of the document
        public void SetAuthor(string authorIn)
        {
            author = authorIn;
        }


        // set the title of the document
        public void SetTitle(string titleIn)
        {
            title = titleIn;
        }
    }
}
