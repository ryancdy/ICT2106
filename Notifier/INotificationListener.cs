//
// ICT2106 Software Design - Observer example
//
// Interface to be implemented by all observers.
//
// Author: Nicholas Sheppard, loosely based on Otero (2012) Ch. 7
//

namespace ICT2106.Notifier
{
    interface INotificationListener
    {
        // send an update
        void Update(string message);
    }
}
