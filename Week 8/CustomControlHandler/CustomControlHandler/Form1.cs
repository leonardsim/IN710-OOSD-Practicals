using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public partial class Form1 : Form
    {
        //Attributes
        CustomControlObserver ccO1;
        CustomControlObserver ccO2;
        Random rand;

        public Form1()
        {
            InitializeComponent();

            // Instantitate them
            rand = new Random();
            ccO1 = new CustomControlObserver(btnTest, rand.Next(100));
            ccO2 = new CustomControlObserver(btnTest, rand.Next(100));
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the form's handler");
        }
    }
}
