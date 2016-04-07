using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class ProgressBarObserver : ProgressEventObserverBase
    {
        //Attribute
        ProgressBar progress;

        //Constructor
        public ProgressBarObserver(ProgressEventSubject subject, ProgressBar progress) : base(subject)
        {
            this.progress = progress;
        }

        //Method
        public override void UpdateProgress(object sender, EventArgs e)
        {
            progress.PerformStep();
        }
    }
}
