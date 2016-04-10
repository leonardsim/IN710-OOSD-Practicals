using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class SpinBoxObserver : ProgressEventObserverBase
    {
        //Attributes
        NumericUpDown spinBox;
        Form1 form;

        //Constructor
        public SpinBoxObserver(ProgressEventSubject subject, NumericUpDown spinBox, Form1 form)
            : base(subject)
        {
            this.spinBox = spinBox;
            this.form = form;
        }

        //Method
        public override void UpdateProgress(object sender, EventArgs e)
        {
            spinBox.Value++;
            form.Refresh();
        }
    }
}
