//
// ICT2106 Software Design - 2D array example
//
// Interface for two-dimensional array iterators.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.TwoDArray
{
    interface ITwoDIterator<T>
    {
        // get the current object in the iteration
        T Current();

        // advance to the next object
        void Next();

        // is the iteration finished?
        bool IsDone();
    }
}
