using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworking
{
    public class FriendObserver : SocialObserver
    {
        //Constructor
        public FriendObserver(ListBox lb, SocialSubject ss)
            : base (lb, ss)
        {

        }

        //Method
        // Override to display the timestamp with status
        public override void Display()
        {
            string format = "ddd d MMM, yyyy HH:mm";
            lb.Items.Add(currentTimeStamp.ToString(format));
            lb.Items.Add(" \"" + currentStatus + "\"");
        }
    }
}
