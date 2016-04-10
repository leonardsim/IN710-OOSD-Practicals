using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogDigitalClock
{
    public partial class Form1 : Form
    {
        //Declare Interface type
        IClock clock;

        public Form1()
        {
            InitializeComponent();
        }

        // Starts the clock
        private void btnStart_Click(object sender, EventArgs e)
        {
            // When button start is clicked, it will be disabled and the stop button
            // will be enabled
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            // If one of the radio button is selected
            if (rdoDigital.Checked)
            {
                // Initialise the digital clock
                clock = new DigitalClock(lblDigital, timer1);

                // Set the analog visibility to be false
                analogClock1.Visible = false;

                // Show the digital clock and turn on the timer
                clock.ShowClock();
                clock.On();
            }
            else if (rdoAnalog.Checked)
            {
                // Initialise the analog clock
                clock = new AnalogClock(analogClock1);

                // Set the digital visibility to be false
                lblDigital.Visible = false;

                // Show the analog clock and start the analog clock
                clock.ShowClock();
                clock.On();
            }
            else // If none of the radio button was selected then a messagebox will pop
            {
                MessageBox.Show("Please select a clock type!");
            }
        }

        // Stops the clock
        private void btnStop_Click(object sender, EventArgs e)
        {
            // When button stop is clicked, it will be disabled and the start button enabled
            btnStart.Enabled = true;
            btnStop.Enabled = false;

            // Stop clock
            clock.Off();
        }

        // Will cosntantly update the label as long as timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.UpdateTimeDisplay();
        }


    }
}
