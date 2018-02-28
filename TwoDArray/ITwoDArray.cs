//
// ICT2106 Software Design - 2D array example
//
// Interface for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.TwoDArray
{
    interface ITwoDArray<T>
    {
        // get an iterator through the array
        ITwoDIterator<T> CreateRowMajorIterator();

        // get the element at position (i, j)
        T Get(int i, int j);

        // set the element at position (i, j)
        void Set(int i, int j, T elem);

        // get the number of rows in the array
        int Rows();

        // get the number of columns in the array
        int Columns();
    }
}
