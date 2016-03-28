using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworking
{
    public class SocialSubject : ISubject
    {
        //Attributes
        private List<IObserver> socialList;
        private string userStatus;
        private DateTime timeStamp;

        //Constructor
        public SocialSubject()
        {
            //Initialise attributes
            socialList = new List<IObserver>();
            userStatus = "";
            timeStamp = DateTime.Now;
        }

        //Methods
        // Adds observer to the list
        public void AddObserver(IObserver o)
        {
            socialList.Add(o);
        }

        // Removes observer from the list
        public void RemoveObserver(IObserver o)
        {
            socialList.Remove(o);
        }

        // Calls the observer's update and display methods
        public void NotifyObservers()
        {
            foreach (SocialObserver currentObserver in socialList)
            {

            }
        }

        //Getters/Setters
        public string UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; }
        }
    }
}
