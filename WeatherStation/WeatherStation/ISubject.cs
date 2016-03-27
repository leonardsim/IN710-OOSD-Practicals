using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface ISubject
    {
        void AddObservers(IObserver o);
        void RemoveObservers(IObserver o);
        void NotifyObservers();
    }
}
