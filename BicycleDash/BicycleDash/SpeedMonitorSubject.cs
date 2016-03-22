using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDash
{
    public class SpeedMonitorSubject : ISubject
    {
        //Variables
        private List<IObserver> observerList;
        private int currentRPM;

        //Constructor
        public SpeedMonitorSubject()
        {
            currentRPM = 0;
            observerList = new List<IObserver>();
        }

        //Method
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }
    }
}
