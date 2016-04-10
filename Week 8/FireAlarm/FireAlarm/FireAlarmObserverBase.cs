using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserverBase
    {
        // Declare subject
        protected FireAlarmSubject sub;

        //Constructor
        public FireAlarmObserverBase(FireAlarmSubject sub)
        {
            this.sub = sub;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(FireAlarmHandlerMethod);

            // Observer gets added to the subject
            sub.FireEvent += handler;
        }

        // Method 
        public abstract void FireAlarmHandlerMethod(object fireSubject, FireEventArgs fa);
    }
}
