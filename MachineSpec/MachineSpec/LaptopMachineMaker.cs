using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class LaptopMachineMaker : IMachineMaker
    {
        CPU lapCPU = null;
        GPU lapGPU = null;
        Memory lapMemory = null;

        public CPU makeCPU()
        {
            lapCPU = new LaptopCPU();
            return lapCPU;
        }

        public GPU makeGPU()
        {
            lapGPU = new LaptopGPU();
            return lapGPU;
        }

        public Memory makeMemory()
        {
            lapMemory = new LaptopMemory();
            return lapMemory;
        }
    }
}
