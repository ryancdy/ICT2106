//
// ICT2106 Software Design - Document Creator example
//
// Interface for all documents.
//
// Author: Nicholas Sheppard
//
using System;

namespace ICT2106.DocumentCreator.Models
{
    public interface IDocument
    {
        // make a deep clone of the document
        IDocument Clone();

        // get a string containing the formatted document
        string GetString();
    }
}
