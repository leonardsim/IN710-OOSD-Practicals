using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    public class ProgressEventSubject
    {
        // Declare event (Bind to delegate type)
        public event EventHandler ProgressEvent;

        //Method
        public void OnUpdateEvent()
        {
            // Instantiate the EventArgs
            EventArgs e = new EventArgs();

            // Is null if no methods have been registered
            if (ProgressEvent != null)
            {
                // Raise the event
                ProgressEvent(this, e);
            }
        }

        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
    }
}
