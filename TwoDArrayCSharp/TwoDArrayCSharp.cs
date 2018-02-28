//
// ICT2106 Software Design - 2D array example
//
// C# implementation of a two-dimensional array with a row-major iterator.
//
// Author: Nicholas Sheppard
//
using System.Collections;

namespace ICT2106.TwoDArrayCSharp
{
    class TwoDArrayCSharp<T>
    {
        // the array
        private T[][] array;

        // constructor
        public TwoDArrayCSharp(int rows, int columns)
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
        public IEnumerable GetRowMajorEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array[i].Length; j++)
                    yield return array[i][j];
        }

        // get the number of rows
        public int Rows()
        {
            return array.Length;
        }

        // get the number of columns
        public int Columns()
        {
            return (Rows() > 0)? array[0].Length : 0;
        }

    }
}
