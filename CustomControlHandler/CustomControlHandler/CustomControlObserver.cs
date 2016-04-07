using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public class CustomControlObserver
    {
        //Attributes
        private Button button;
        private int codeNum;

        //Constructor
        public CustomControlObserver(Button button, int codeNum)
        {
            this.button = button;
            this.codeNum = codeNum;

            // Create event handler delegate and bind the method to it
            EventHandler handler = new EventHandler(CustomControlHandlerMethod);

        }

        //Method to pass into delegate event handler
        public void CustomControlHandlerMethod(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("This is a custom handler");
            sb.AppendLine("My code number is " + codeNum);
            sb.AppendLine("My type is " + this.GetType().ToString());
            sb.AppendLine("I am responding to button: " + button.Name);

            // Display to MessageBox
            MessageBox.Show(sb.ToString());
        }

    }
}
