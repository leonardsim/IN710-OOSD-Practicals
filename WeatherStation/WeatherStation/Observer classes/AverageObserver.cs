using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class AverageObserver : WeatherObserver
    {
        //Variables
        int runningTemp;
        int runningHumidity;
        int runningPressure;
        int avgCount;

        //Constructor
        public AverageObserver(ListBox lb, WeatherSubject subject) 
            : base(lb, subject)
        {
            // Initialise variables
            runningTemp = 0;
            runningHumidity = 0;
            runningPressure = 0;
            avgCount = 0;
        }

        //Method
        // Averages and displays all the readings received since the program started
        public override void Update(int currentTemp, int curentHumidity, int currentPressure)
        {
            // Increment count first
            avgCount++;

            // Sum up all current readings
            runningTemp += currentTemp;
            runningHumidity += curentHumidity;
            runningPressure += currentPressure;

            // Average the running values 
            computedTemp = ((double)runningTemp / avgCount);
            computedHumidity = ((double)runningHumidity / avgCount);
            computedPressure = ((double)runningPressure / avgCount);
        }
    }
}
