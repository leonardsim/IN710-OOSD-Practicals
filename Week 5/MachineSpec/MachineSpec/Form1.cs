using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineSpec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IMachineMaker currMachineMaker;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // BAD ARCHITECTURAL DESIGN
            // Have to constantly change if statements if new classes are added
            if (rdoGame.Checked == false && rdoBusiness.Checked == false && rdoMulti.Checked == false && rdoLaptop.Checked == false)
            {
                MessageBox.Show("Please select a machine type");
            } 
            else
            {
                if (rdoGame.Checked)
                    currMachineMaker = new GameMachineMaker();
                else if (rdoBusiness.Checked)
                    currMachineMaker = new BusinessMachineMaker();
                else if (rdoMulti.Checked)
                    currMachineMaker = new MultimediaMachineMaker();
                else if (rdoLaptop.Checked)
                    currMachineMaker = new LaptopMachineMaker();

                MachineSpecPrinter currSpecPrinter = new MachineSpecPrinter(currMachineMaker, listBox1);
                currSpecPrinter.printSpec();
            }
        }


    }
}
