using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public class TrackBarObserver : ProgressEventObserverBase
    {
        //Attributes
        TrackBar track;

        //Constrcutor
        public TrackBarObserver(ProgressEventSubject subject, TrackBar track) : base(subject)
        {
            this.track = track;
        }

        //Method
        public override void UpdateProgress(object sender, EventArgs e)
        {
            track.Value++;
        }
    }
}
