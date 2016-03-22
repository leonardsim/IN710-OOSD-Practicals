using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDash
{
    class KilometerObserver : BicycleObserver
    {
        //Constructor
        public KilometerObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {

        }

        //Methods
        public override void Update(int currentRPM)
        {
            currentComputedValue = (currentRPM / (1 / 0.205)) / (60);
        }
    }
}
