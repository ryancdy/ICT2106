//
// ICT2106 Software Design - Observer example
//
// A class that notifies observers every time the user types a message in the console.
//
// Author: Nicholas Sheppard, Observer pattern, loosely based on Otero (2012) Ch. 7
//
using System;

namespace ICT2106.Notifier
{
    class ConsoleReader : AbstractNotifier
    {
        // constructor
        public ConsoleReader()
        {
            // nothing do to
        }

        // read lines from the console, sending a notification every time the user presses "enter"
        public void ReadLines()
        {
            // print some instructions
            Console.WriteLine("Enter text one line at a time.");
            Console.WriteLine("A notification will be sent every time you press 'enter'.");
            Console.WriteLine("Enter an empty line to finish.");
            Console.WriteLine();

            // read lines and notify
            string line = Console.ReadLine();
            while (line.Length > 0)
            {
                Notify(line);
                line = Console.ReadLine();
            }

        }
    }
}
