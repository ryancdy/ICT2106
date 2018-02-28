//
// ICT2106 Software Design - Document Creator example
//
// Abstract Factory pattern, by Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models
{
    public interface IDocumentFactory
    {
        IHeading CreateHeading(int level, string text);
        IParagraph CreateParagraph(string text);
    }
}
