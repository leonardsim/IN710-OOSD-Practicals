using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogDigitalClock
{
    public interface IClock
    {
        void On();
        void Off();
        void UpdateTimeDisplay();
        void ShowClock();
        void HideClock();

    }
}
