﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZoologicalSim.AnimalClasses;

namespace ZoologicalSim
{
    public class NorthAmericanAnimalFactory : IAnimalFactory
    {
        // I.method
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Bison();
                    break;
                case 1:
                    newAnimal = new Wolf();
                    break;
                case 2:
                    newAnimal = new Eagle();
                    break;
                case 3:
                    newAnimal = new Bear();
                    break;
            }

            return newAnimal;
        }
    }
}
