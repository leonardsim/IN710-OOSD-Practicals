﻿using System;
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
        
        // Declare event (Bind to the delegate type)
        public event FireEventHandler FireEvent;

        // Method
        public void OnFireEvent(EFireCategory fCat)
        {
            // Instantiate the custom event
            FireEventArgs fe = new FireEventArgs(fCat);

            if (FireEvent != null)
            {
                FireEvent(this, fe);
            }
        }
    }
}
