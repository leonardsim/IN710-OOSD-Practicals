using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigitalClock
{
    public class DigitalClock : IClock
    {
        //Variables
        Label timeDisplayLabel;
        Timer timer;

        //Constructor
        public DigitalClock(Label timeDisplayLabel, Timer timer)
        {
            this.timeDisplayLabel = timeDisplayLabel;
            this.timer = timer;
        }

        //Methods
        // Turns timer on
        public void On()
        {
            timer.Enabled = true;
        }

        // Turns timer off
        public void Off()
        {
            timer.Enabled = false;
        }

        // Displays the time onto the label
        public void UpdateTimeDisplay()
        {
            timeDisplayLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Turns visibility of digital clock on
        public void ShowClock()
        {
            timeDisplayLabel.Visible = true;
        }

        // Turns visibility of digital clock off
        public void HideClock()
        {
            timeDisplayLabel.Visible = false;
        }
    }
}
