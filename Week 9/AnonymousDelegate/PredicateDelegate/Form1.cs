using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredicateDelegate
{
    public partial class Form1 : Form
    {
        //Attributes
        List<int> numList;
        Random rand;

        public Form1()
        {
            InitializeComponent();

            // Instantiate attributes
            numList = new List<int>();
            rand = new Random();
        }

        //Method

        private void generateRand()
        {
            for (int i = 0; i < 30; i++)
            {
                // Generate number between 0 - 100
                int randNum = rand.Next(101);

                // Add the number into the list
                numList.Add(randNum);
            }
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            // Clear number list and list boxes
            numList.Clear();
            lbResult.Items.Clear();
            lbRand.Items.Clear();

            generateRand();

            foreach (int i in numList)
            {
                lbRand.Items.Add(i);
            }
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            // Clear list box
            lbResult.Items.Clear();

            // Replaced predicate delegate with lamda expressions
            List<int> results = numList.FindAll((i) => (i % 2) == 1);

            // Display it onto the listbox
            foreach (int r in results)
            {
                lbResult.Items.Add(r);
            }
            
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            // Clear list box
            lbResult.Items.Clear();

            List<int> results = numList.FindAll((i) => (i < 10));

            // Display it onto the listbox
            foreach (int r in results)
            {
                lbResult.Items.Add(r);
            }
        }
    }
}
