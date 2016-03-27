using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherSubject : ISubject
    {
        //Variables
        private List<IObserver> weatherList;
        private int currentTemp;
        private int currentPressure;
        private int currentHumidity;

        //Constructor
        public WeatherSubject()
        {
            // Inititalise all the variables
            currentTemp = 0;
            currentHumidity = 0;
            currentPressure = 0;
            weatherList = new List<IObserver>();
        }

        //Getters/Setters
        public int CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public int CurrentPressure
        {
            get { return currentPressure; }
            set { currentPressure = value; }
        }

        public int CurrentHumidity
        {
            get { return currentHumidity; }
            set { currentHumidity = value; }
        }
    }
}
