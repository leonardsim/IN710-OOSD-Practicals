using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class MultimediaMachineMaker : IMachineMaker
    {
        CPU mulCPU = null;
        GPU mulGPU = null;
        Memory mulMemory = null;

        public CPU makeCPU()
        {
            mulCPU = new MultimediaCPU();
            return mulCPU;
        }

        public GPU makeGPU()
        {
            mulGPU = new MultimediaGPU();
            return mulGPU;
        }

        public Memory makeMemory()
        {
            mulMemory = new MultimediaMemory();
            return mulMemory;
        }
    }
}
