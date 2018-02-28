//
// ICT2106 Software Design - 2D array example
//
// Main program, C# version.
//
// Author: Nicholas Sheppard
//

using System;

namespace ICT2106.TwoDArrayCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create and fill a 2 x 3 array of integers
            TwoDArrayCSharp<int> array = new TwoDArrayCSharp<int>(2, 3);
            array.Set(0, 0, 9); array.Set(0, 1, 4); array.Set(0, 2, 1);
            array.Set(1, 0, 2); array.Set(1, 1, 5); array.Set(1, 2, 3);

            // display the array in row major order
            foreach (int n in array.GetRowMajorEnumerator())
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
