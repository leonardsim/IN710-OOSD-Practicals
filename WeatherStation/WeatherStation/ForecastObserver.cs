using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class ForecastObserver : WeatherObserver
    {
        //Variables
        string weatherStr;

        //Constructor 
        public ForecastObserver(ListBox lb, WeatherSubject subject) 
            : base(lb, subject)
        {
            weatherStr = "";
        }

        //Methods
        // Saves a message and message generated depends on temperature and humidity entered
        public override void Update(int currentTemp, int curentHumidity, int currentPressure)
        {
            // Checks temperature range and adds a message to string
            if (currentTemp < 0)
            {
                weatherStr = "Arctic level cold! ";
            }
            else if (currentTemp > 0 && currentTemp < 11)
            {
                weatherStr = "Very cold, be sure to wear layers of clothes. ";
            }
            else if (currentTemp > 10 && currentTemp < 21)
            {
                weatherStr = "Temperature is just right. ";
            }
            else if (currentTemp > 20 && currentTemp < 31)
            {
                weatherStr = "It's gon' be hot today!";
            }
            else if (currentTemp > 30)
            {
                weatherStr = "TOO HOT!";
            }

            // Checks humidity range and adds a message to string
            if (currentHumidity > 0 && currentHumidity < 31)
            {
                weatherStr += "Air is too dry!";
            }
            else if (currentHumidity > 30 && currentHumidity < 61)
            {
                weatherStr += "Optimum humidity!";
            }
            else if (currentHumidity > 60 && currentHumidity < 101)
            {
                weatherStr += "Air is too humid!";
            }
        }

        // Overriden Display method to display the string text
        public override void Display()
        {
            // Clears the list box
            lb.Items.Clear();

            lb.Items.Add(weatherStr);
        }
    }
}
