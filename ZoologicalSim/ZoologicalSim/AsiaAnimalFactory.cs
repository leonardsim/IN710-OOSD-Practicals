using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoologicalSim.AnimalClasses;

namespace ZoologicalSim
{
    public class AsiaAnimalFactory : IAnimalFactory
    {
        // I.method
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new OrangUtan();
                    break;
                case 1:
                    newAnimal = new Tiger();
                    break;
                case 2:
                    newAnimal = new Panda();
                    break;
                case 3:
                    newAnimal = new Elephant();
                    break;
            }

            return newAnimal;
        }
    }
}
