//
// ICT2106 Software Design - Document Creator example
//
// Interface for docuemnt headings
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models
{
    public interface IHeading
    {
        // get a string containing the heading
        string GetString();

        // get the level of the heading
        int GetLevel();
    }
}
