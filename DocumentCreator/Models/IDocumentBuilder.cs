//
// ICT2106 Software Design - Document Creator example
//
// Interface for all document builders.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models
{
    public interface IDocumentBuilder
    {
        void OpenDocument();
        void BuildHead(string title, string author);
        void BuildBody(string text);
        void CloseDocument();
        IDocument GetDocument();
    }
}
