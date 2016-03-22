using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDash
{
    public abstract class BicycleObserver : IObserver
    {
        //Variables
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SpeedMonitorSubject bikeSubject;

        //Constructor
        public BicycleObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
        {
            this.displayLabel = displayLabel;

            currentRPM = 0;
            currentComputedValue = 0;
            this.bikeSubject = bikeSubject;

            //Observers will sign themselves to the list
            bikeSubject.AddObserver(this);
        }

        //Methods
        public abstract void Update(int currentRPM);
        
        public virtual void DisplayData()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}
