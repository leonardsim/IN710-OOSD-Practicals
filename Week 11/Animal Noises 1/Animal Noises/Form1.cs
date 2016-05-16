using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Animal mainAnimal;
        private Thread t;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();

            // Create ThreadStart and feed in the speak method
            ThreadStart ts = new ThreadStart(mainAnimal.speak);

            t = new Thread(ts);
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            // Start the thread
            t.Start();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Kills the thread
            t.Abort();
        }


    }
}
