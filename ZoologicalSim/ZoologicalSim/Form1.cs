using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoologicalSim
{
    public partial class Form1 : Form
    {
        //Constant
        const int ANIMAL_COUNT = 3;

        //Variables
        Continent mCon;
        Random rGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();

            rGen = new Random();
            canvas = this.CreateGraphics();
            mCon = new NorthAmerica(lbAnimals, rGen, ANIMAL_COUNT, canvas);
        }

        private void btnNA_Click(object sender, EventArgs e)
        {
            // Clear the graphics and listbox
            lbAnimals.Items.Clear();
            canvas.Clear(Form1.ActiveForm.BackColor);

            // Run simulation
            mCon.runSimulation();
        }
    }
}
