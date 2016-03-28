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
        public void AddObserver(IObserver o)
        {
            socialList.Add(o);
        }

        //Getters/Setters
        public string UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; }
        }
    }
}
