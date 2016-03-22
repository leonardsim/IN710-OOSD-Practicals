using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDash
{
    class CaloriesObserver : BicycleObserver
    {
        //Constructor
        public CaloriesObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {

        }

        //Methods
        public override void Update(int currentRPM)
        {
            currentComputedValue = 5 * currentRPM;
        }
    }
}
