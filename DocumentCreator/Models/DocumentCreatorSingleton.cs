//
// ICT2106 Software Design - Document Creator example
//
// An example of the Singleton pattern, used here to provide some utility functions
// used elsewhere in the application.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models
{
    public class DocumentCreatorSingleton
    {
        // the sole instance of this class
        private static DocumentCreatorSingleton instance = null;

        // constructor - note that it is declared private so that only this class can instantiate itself
        private DocumentCreatorSingleton()
        {
            // nothing to do
        }

        // get a reference to the sole instance of this class, creating it if necessary
        public static DocumentCreatorSingleton GetInstance()
        {
            if (instance == null)
                instance = new DocumentCreatorSingleton();

            return instance;
        }

        // instantiate a document builder for a given output format
        public IDocumentBuilder GetDocumentBuilder(string format)
        {
            switch (format)
            {
                case "html":
                    return new Html.HtmlDocumentBuilder();

                case "latex":
                    return new Latex.LatexDocumentBuilder();
                case "plain":
                    return new Plain.PlainDocumentBuilder();
                default:
                    return null;
            }
        }

        // instantiate a document factory for a given output format
        public IDocumentFactory GetDocumentFactory(string format)
        {
            switch (format)
            {
                case "html":
                    return new Html.HtmlDocumentFactory();

                case "latex":
                    return new Latex.LatexDocumentFactory();
                
                case "plain":
                    return new Plain.PlainDocumentFactory();
                default:
                    return null;
            }
        }

        // get a sample document containing some standard text
        public IDocument GetSampleDocument(string format)
        {
            IDocumentBuilder builder = GetDocumentBuilder(format);

            // this text is taken from the ICT2106 module synopsis
            builder.OpenDocument();
            builder.BuildHead("ICT2106 Software Design", "Nicholas Sheppard");
            builder.BuildBody(
                "Software design is concerned with issues, techniques, strategies, representations, and patterns used to determine how to implement a component or a system. " +
                "\nThe design will conform to functional requirements as well as non-functional requirements such as resource, performance, reliability and security. " +
                "\nThis module focuses on techniques for software design in the context of large and complex software systems. " +
                "\nTopics include software architecture, design principles (information hiding, cohesion and coupling), design notations, evaluation methods and their associated software tools. " +
                "\nThe course introduces more advanced design notations and concepts. " +
                "\nSeveral design methods are presented and compared, with accompanying examples and case studies. " +
                "\nAn emphasis will be on placed on the application of design principles and evaluation of their trade-offs to the creation of successful software."
            );
            builder.CloseDocument();

            return builder.GetDocument();
        }
    }
}
