using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public interface IMachineMaker
    {
        CPU makeCPU();
        GPU makeGPU();
        Memory makeMemory();
    }
}
