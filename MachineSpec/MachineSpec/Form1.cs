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
            if (rdoGame.Checked == false && rdoBusiness.Checked == false && rdoMulti.Checked == false)
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

                MachineSpecPrinter currSpecPrinter = new MachineSpecPrinter(currMachineMaker, listBox1);
                currSpecPrinter.printSpec();
            }
        }


    }
}
