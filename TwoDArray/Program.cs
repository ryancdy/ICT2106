//
// ICT2106 Software Design - 2D array example
//
// Main program.
//
// Author: Nicholas Sheppard
//
using System;

namespace ICT2106.TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            ITwoDArray<int> array = new TwoDArrayGeneric<int>(2, 3);
            array.Set(0, 0, 9); array.Set(0, 1, 4); array.Set(0, 2, 1);
            array.Set(1, 0, 2); array.Set(1, 1, 5); array.Set(1, 2, 3);

            // display the array in row major order
            ITwoDIterator<int> iter = array.CreateRowMajorIterator();
            while (!iter.IsDone())
            {
                Console.Write(iter.Current() + " ");
                iter.Next();
            }
            Console.WriteLine();
        }
    }
}
