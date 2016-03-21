using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineSpec
{
    class MachineSpecPrinter
    {
        //Variables
        private IMachineMaker machineMaker;
        private ListBox displayBox;

        //Constructor
        public MachineSpecPrinter(IMachineMaker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        //Method
        public void printSpec()
        {
            CPU currCPU = machineMaker.makeCPU();
            Memory currMemory = machineMaker.makeMemory();
            GPU currGPU = machineMaker.makeGPU();

            double totalPrice = currCPU.Price + currGPU.Price + currMemory.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("*********************************");

            displayBox.Items.Add(currCPU.ToString());
            displayBox.Items.Add(currGPU.ToString());
            displayBox.Items.Add(currMemory.ToString());

            displayBox.Items.Add("*********************************");
            displayBox.Items.Add("Total Price: " + totalPrice.ToString());
        }
    }
}
