using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class BusinessMachineMaker : IMachineMaker
    {
        CPU busCPU = null;
        GPU busGPU = null;
        Memory busMemory = null;

        public CPU makeCPU()
        {
            busCPU = new BusinessCPU();
            return busCPU;
        }

        public GPU makeGPU()
        {
            busGPU = new BusinessGPU();
            return busGPU;
        }

        public Memory makeMemory()
        {
            busMemory = new BusinessMemory();
            return busMemory;
        }
    }
}
