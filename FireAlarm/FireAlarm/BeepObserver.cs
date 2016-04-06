using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BeepObserver : FireAlarmObserverBase
    {
        //Import beep method from kernel32 library
        [DllImport("kernel32.dll")]

        // Beep method
        public static extern bool Beep(int freq, int duration);

        //Constructor
        public BeepObserver(FireAlarmSubject sub) : base(sub)
        {

        }

        //Method
        public override void FireAlarmHandlerMethod(object fireSubject, FireEventArgs fa)
        {
            // Beep duration and frequency
            int duration = 1000;
            int frequency = 0;

            switch(fa.FireCategory)
            {
                case EFireCategory.MINOR:
                    frequency = 800;
                    break;
                case EFireCategory.SERIOUS:
                    frequency = 1200;
                    break;
                case EFireCategory.INFERNO:
                    frequency = 1600;
                    break;
            }

            Beep(frequency, duration);
        }
    }
}
