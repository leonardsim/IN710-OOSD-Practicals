using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class FireAlarmSubject
    {
        // Declare delegate
        public delegate void FireEventHandler(object fireSubject, FireEventArgs fe);
        
        // Declare event
        public event FireEventHandler FireEvent;

        
    }
}
