using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            mainAnimal.speak();
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }


    }
}
