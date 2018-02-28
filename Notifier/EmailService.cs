//
// ICT2106 Software Design - Observer example
//
// An observer that sends notification by e-mail.
//
// Author: Nicholas Sheppard, loosely based on Otero (2012) Ch. 7
//
using System;

namespace ICT2106.Notifier
{
    class EmailService : INotificationListener
    {
        // the e-mail address to be notified
        private string address;

        // constructor
        public EmailService(string addressIn)
        {
            // save the address for later
            address = addressIn;
        }

        // send an update message (actually just print it on the screen)
        public void Update(string message)
        {
            Console.WriteLine(">> To: " + address);
            Console.WriteLine(">> " + message);
            Console.WriteLine();
        }
    }
}
