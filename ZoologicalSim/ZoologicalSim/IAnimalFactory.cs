using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicalSim
{
    public interface IAnimalFactory
    {
        // Creates animals
        Animal createAnimal(int animalCode);
    }
}
