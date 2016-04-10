using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressFeedbackDisplay
{
    public partial class Form1 : Form
    {
        // Declare delegate
        public delegate void FeedbackDelegate();


        public Form1()
        {
            InitializeComponent();
        }

        //Methods
        // Will increase the numeric value of the spinbox
        public void updateSpinBox()
        {
            // Automatically update the visual state by forcing the screen to redraw
            Application.DoEvents();
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

        // Will slow down the progress
        public void slowMethod(FeedbackDelegate feedback)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                feedback();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Reset all the feedback values
            numericUpDown1.Value = 0;
            progressBar1.Value = 0;
            trackBar1.Value = 0;

            // Create FeedbackDelegate instance
            FeedbackDelegate feedback = null;

            // Bind delegate dynamically
            if (rdoSpin.Checked)
            {
                feedback = new FeedbackDelegate(updateSpinBox);
            }
            else if (rdoProg.Checked)
            {
                feedback = new FeedbackDelegate(updateProgressBar);
            }
            else if (rdoTrack.Checked)
            {
                feedback = new FeedbackDelegate(updateTrackBar);
            }

            slowMethod(feedback);
        }
    }
}
