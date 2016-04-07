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
        }

        //Method to pass into delegate event handler
        public void CustomControlHandlerMethod(object sender, EventArgs e)
        {
            
        }

    }
}
