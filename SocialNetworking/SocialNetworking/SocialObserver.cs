using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking
{
    public abstract class SocialObserver : IObserver
    {
        //Attributes
        protected string currentStatus;
        protected DateTime currentTimeStamp;
        protected ListBox lb;
        protected SocialSubject ss;

        //Constructor
        public SocialObserver(ListBox lb, SocialSubject ss)
        {
            // Inititalise attributes
            currentStatus = "";
            currentTimeStamp = DateTime.Now;

            this.lb = lb;
            this.ss = ss;

            ss.AddObserver(this);
        }

        //Methods
        public virtual void Update(string userInput)
        {
            currentStatus = userInput;
            currentTimeStamp = DateTime.Now;
        }

        public virtual void Display()
        {
            lb.Items.Add("Status: " + currentStatus);
        }
 

        //Getter/Setter
        public string CurrentStatus
        {
            get { return currentStatus; }
            set { currentStatus = value; }
        }

        public DateTime CurrentTimeStamp
        {
            get { return currentTimeStamp; }
            set { currentTimeStamp = value; }
        }
    }
}
