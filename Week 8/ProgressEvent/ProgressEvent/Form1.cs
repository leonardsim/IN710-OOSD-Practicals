using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressEvent
{
    public partial class Form1 : Form
    {
        // Declare subject and obeservers
        ProgressEventSubject subject;
        SpinBoxObserver spO;
        ProgressBarObserver pbO;
        TrackBarObserver tbO;

        public Form1()
        {
            InitializeComponent();

            // Instantiate them
            subject = new ProgressEventSubject();
            pbO = new ProgressBarObserver(subject, progressBar1);
            spO = new SpinBoxObserver(subject, numericUpDown1, this);
            tbO = new TrackBarObserver(subject, trackBar1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            subject.SlowMethod();
        }
    }
}
