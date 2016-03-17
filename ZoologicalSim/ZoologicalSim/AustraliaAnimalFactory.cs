using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoologicalSim.AnimalClasses;

namespace ZoologicalSim
{
    public class AustraliaAnimalFactory : IAnimalFactory
    {
        // I.method
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Kangaroo();
                    break;
                case 1:
                    newAnimal = new Dingo();
                    break;
                case 2:
                    newAnimal = new Crocodile();
                    break;
                case 3:
                    newAnimal = new Koala();
                    break;
            }

            return newAnimal;
        }
    }
}
