using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressFeedbackDisplay
{
    public partial class Form1 : Form
    {
        //Declare delegate
        public delegate void FeedbackDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        //Methods
        // Will increase the numeric value of the spinbox
        public void updateSpinBox()
        {
            numericUpDown1.Value++;
        }

        // Will update the progress bar
        public void updateProgressBar()
        {
            progressBar1.PerformStep();
        }

        // Will update the trackbar
        public void updateTrackBar()
        {
            trackBar1.Value++;
        }
    }
}
