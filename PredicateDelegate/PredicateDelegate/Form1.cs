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
        List<int> num;
        Random rand;

        public Form1()
        {
            InitializeComponent();

            // Instantiate attributes
            num = new List<int>();
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

        private void btnRand_Click(object sender, EventArgs e)
        {

        }

        private void btnEven_Click(object sender, EventArgs e)
        {

        }

        private void btnTen_Click(object sender, EventArgs e)
        {

        }
    }
}
