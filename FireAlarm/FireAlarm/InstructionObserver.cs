using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public class InstructionObserver : FireAlarmObserverBase
    {
        //Constructor
        public InstructionObserver(FireAlarmSubject sub) : base(sub)
        {

        }

        //Method
        public override void FireAlarmHandlerMethod(object fireSubject, FireEventArgs fa)
        {
            // Feedback message
            String message = "Fire category is " + fa.FireCategory.ToString() + ".";

            // Depending on which enum was picked, a str will be concat'd to the message
            switch(fa.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += " Use a fire extinguisher!";
                    break;
                case EFireCategory.SERIOUS:
                    message += " Call the fire department!";
                    break;
                case EFireCategory.INFERNO:
                    message += " Evacuate immediately!!";
                    break;
            }

            // Message box will appear
            MessageBox.Show(message);
        }
    }
}
