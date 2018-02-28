//
// ICT2106 Software Design - Observer example
//
// Abstract base class for all notifying classes
//
// Author: Nicholas Sheppard, loosely based on Otero (2012) Ch. 7
//
using System.Collections.Generic;

namespace ICT2106.Notifier
{
    class AbstractNotifier
    {
        // the list of services to be sent notifications
        private ICollection<INotificationListener> listeners;

        // constructor
        public AbstractNotifier()
        {
            // start with an empty list of services
            listeners = new List<INotificationListener>();
        }

        // register a message service
        public void Attach(INotificationListener listener)
        {
            listeners.Add(listener);
        }

        // de-register a message service
        public void Detach(INotificationListener listener)
        {
            listeners.Remove(listener);
        }

        // notify all message services
        protected void Notify(string message)
        {
            foreach (INotificationListener listener in listeners)
            {
                listener.Update(message);
            }
        }
    }
}
