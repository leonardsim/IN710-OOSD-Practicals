using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class GameMachineMaker : IMachineMaker
    {
        CPU gameCPU = null;
        GPU gameGPU = null;
        Memory gameMemory = null;

        public CPU makeCPU()
        {
            gameCPU = new GameCPU();
            return gameCPU;
        }

        public GPU makeGPU()
        {
            gameGPU = new GameGPU();
            return gameGPU;
        }

        public Memory makeMemory()
        {
            gameMemory = new GameMemory();
            return gameMemory;
        }
    }
}
