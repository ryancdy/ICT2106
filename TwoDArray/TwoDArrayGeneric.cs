//
// ICT2106 Software Design - 2D array example
//
// Implementation of a basic two-dimensional array.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.TwoDArray
{
    class TwoDArrayGeneric<T> : ITwoDArray<T>
    {
        // the array
        private T[][] array;

        // constructor
        public TwoDArrayGeneric(int rows, int columns)
        {
            // allocate memory for the array
            array = new T[rows][];
            for (int i = 0; i < rows; i++)
                array[i] = new T[columns];
        }

        // get the element at (i, j)
        public T Get(int i, int j)
        {
            return array[i][j];
        }

        // set the element at (i, j)
        public void Set(int i, int j, T elem)
        {
            array[i][j] = elem;
        }

        // get an iterator that will traverse the array in row major order
        public ITwoDIterator<T> CreateRowMajorIterator()
        {
            return new TwoDRowMajorIteratorGeneric<T>(this);
        }

        // get the number of columns in the array
        public int Columns()
        {
            return array[0].Length;
        }

        // get the number of rows in the array
        public int Rows()
        {
            return array.Length;
        }

    }
}
