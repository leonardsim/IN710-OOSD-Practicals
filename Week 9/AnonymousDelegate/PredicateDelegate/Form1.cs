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

        private void LamdaFilter(Predicate<int> filter)
        {
            // Clear list box
            lbResult.Items.Clear();

            // List box that will save the filtered values
            List<int> filtered = numList.FindAll(filter);

            foreach(int i in filtered)
            {
                lbResult.Items.Add(i.ToString());
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
            LamdaFilter(n => (n % 2 == 1));
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            LamdaFilter(n => (n < 10));
        }
    }
}
