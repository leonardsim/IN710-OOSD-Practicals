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
        // Checks to see if the input is an odd number
        private bool isOdd(int inputInteger)
        {
            bool isAnOddNumber = ((inputInteger % 2) == 1);
            return isAnOddNumber;
        }

        // Checks to see if the input is less than 10
        private bool isLessThan(int inputInteger)
        {
            bool isLessThanTen;

            if (inputInteger < 10)
            {
                isLessThanTen = true;
            }
            else
            {
                isLessThanTen = false;
            }

            return isLessThanTen;
        }

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

            // Declare, initialize and instantiate Predicate
            Predicate<int> isOddPredicate = new Predicate<int>(isOdd);

            // Call FindAll method which accepts a Predicate and returns a list of int composed
            // of all elelemts of the target list for which the Predicate returns true
            List<int> results = numList.FindAll(isOddPredicate);

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

            // Declare, initialize and instantiate Predicate
            Predicate<int> isLessThanPredicate = new Predicate<int>(isLessThan);

            // Call FindAll method which accepts a Predicate and returns a list of int composed
            // of all elelemts of the target list for which the Predicate returns true
            List<int> results = numList.FindAll(isLessThanPredicate);

            // Display it onto the listbox
            foreach (int r in results)
            {
                lbResult.Items.Add(r);
            }
        }
    }
}
