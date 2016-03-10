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
        Label timeDisplayLabel;
        Timer timer;

        public DigitalClock(Label timeDisplayLabel, Timer timer)
        {
            this.timeDisplayLabel = timeDisplayLabel;
            this.timer = timer;
        }


    }
}
