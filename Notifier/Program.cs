//
// ICT2106 Software Design - Observer example
//
// Main program.
//
// Author: Nicholas Sheppard, loosely based on Otero (2012) Ch. 7
//

namespace ICT2106.Notifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // create some e-mail addresses to receive notifications
            EmailService email1 = new EmailService("A.Student@SingaporeTech.edu.sg");
            EmailService email2 = new EmailService("A.Faculty@SingaporeTech.edu.sg");

            // create a notifier and register the notification services
            ConsoleReader reader = new ConsoleReader();
            reader.Attach(email1);
            reader.Attach(email2);

            // go!
            reader.ReadLines();
        }
    }
}
