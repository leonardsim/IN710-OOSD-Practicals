using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressEvent
{
    public abstract class ProgressEventObserverBase
    {
        // Declare subject
        protected ProgressEventSubject subject;

        //Constructor
        public ProgressEventObserverBase(ProgressEventSubject subject)
        {
            this.subject = subject;

            EventHandler handler = new EventHandler(UpdateProgress);

            subject.ProgressEvent += handler;
        }

        //Method
        public abstract void UpdateProgress(object sender, EventArgs e);
    }
}
