using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworking
{
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

        //Getters/Setters
        public string UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; }
        }
    }
}
