using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigitalClock
{
    public class AnalogClock : IClock
    {
        //Variables
        AnalogClockControl.AnalogClock analogClock;

        //Constructor
        public AnalogClock(AnalogClockControl.AnalogClock analogClock)
        {
            this.analogClock = analogClock;
        }

        //Methods
        // Starts the analog clock
        public void On()
        {
            analogClock.Start();
        }

        // Stops the analog clock
        public void Off()
        {
            analogClock.Stop();
        }

        // This method is not used
        public void UpdateTimeDisplay()
        {

        }

        // Turns visibility of analog clock on
        public void ShowClock()
        {
            analogClock.Visible = true;
        }

        // Turns visibility of analog clock off
        public void HideClock()
        {
            analogClock.Visible = false;
        }
    }
}
