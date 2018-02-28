//
// ICT2106 Software Design - Document Creator example
//
// Base class for all LaTeX elements.
//
// Author: Nicholas Sheppard


namespace ICT2106.DocumentCreator.Models.Latex
{
    public abstract class LatexElement
    {
        // create a deep clone of the element
        public abstract LatexElement Clone();

        // get a string representing the element
        public abstract string GetString();
    }
}
