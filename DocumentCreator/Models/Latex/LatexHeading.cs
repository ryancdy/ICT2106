//
// ICT2106 Software Design - Document Creator example
//
// LaTeX heading.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.DocumentCreator.Models.Latex
{
    class LatexHeading : LatexElement, IHeading
    {
        private int level;
        private string text;

        // LaTeX commands for headings, from highest to lowest
        private static string[] COMMAND =
        {
            "chapter", "section", "subsection", "subsubsection", "paragraph"
        };

        // constructor
        public LatexHeading(int levelIn, string textIn)
        {
            level = levelIn;
            text = textIn;

            // make sure that the heading level is one of those defined in COMMAND
            if (level < 1)
                level = 1;
            else if (level >= COMMAND.Length)
                level = COMMAND.Length - 1;
        }

        // create a deep clone of the heading
        public override LatexElement Clone()
        {
            return new LatexHeading(level, text);
        }

        // LaTeX headings are denoted by \chapter{}, \section{}, \subsection{}, etc.
        public override string GetString()
        {
            return "\\" + COMMAND[level - 1] + "{" + text + "}\n\n";
        }

        // get the level of theading
        public int GetLevel()
        {
            return level;
        }
    }
}
