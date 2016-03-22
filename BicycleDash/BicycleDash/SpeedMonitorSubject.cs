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

        //Methods
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (BicycleObserver currentObserver in observerList)
            {
                currentObserver.Update(currentRPM);
                currentObserver.Display();
            }
        }

        //Getter/Setter
        public int CurrentRPM
        {
            get { return currentRPM; }
            set { currentRPM = value; }
        }
    }
}
