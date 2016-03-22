using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDash
{
    class RPMObserver : BicycleObserver
    {
        //Constructor
        public RPMObserver(Label displayLabel, SpeedMonitorSubject bikeSubject) 
            : base (displayLabel, bikeSubject)
        {

        }

        //Methods
        public override void Update(int currentRPM)
        {
            currentComputedValue = currentRPM;
        }

    }
}
