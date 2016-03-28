using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public abstract class WeatherObserver : IObserver
    {
        //Variables
        protected int currentTemp;
        protected int currentHumidity;
        protected int currentPressure;
        protected double computedTemp;
        protected double computedHumidity;
        protected double computedPressure;
        protected ListBox lb;
        protected WeatherSubject subject;

        //Constructor
        public WeatherObserver(ListBox lb, WeatherSubject subject)
        {
            // Inititalise variables
            currentTemp = 0;
            currentHumidity = 0;
            currentPressure = 0;

            this.lb = lb;
            this.subject = subject;

            // Adds Observer to the Observer list
            subject.AddObservers(this);
        }

        //Getters/Setters
        // Current Readings
        public int CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }
        public int CurrentHumidity
        {
            get { return currentHumidity; }
            set { currentHumidity = value; }
        }

        public int CurrentPressure
        {
            get { return currentPressure; }
            set { currentPressure = value; }
        }

        // Computed Readings
        public double ComputedTemp
        {
            get { return computedTemp; }
            set { computedTemp = value; }
        }

        public double ComputedHumidity
        {
            get { return computedHumidity; }
            set { computedHumidity = value; }
        }

        public double ComputedPressure
        {
            get { return computedPressure; }
            set { computedPressure = value; }
        }

    }
}
