using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class CurrentObserver : WeatherObserver
    {
        //Constructor
        public CurrentObserver(ListBox lb, WeatherSubject subject)
            : base (lb, subject)
        {

        }

        //Method
        // Prints the user's most current input to the list box
        public override void Update(int currentTemp, int currentHumidity, int currentPressure)
        {
            computedTemp = currentTemp;
            computedHumidity = currentHumidity;
            computedPressure = currentPressure;
        }
    }
}
