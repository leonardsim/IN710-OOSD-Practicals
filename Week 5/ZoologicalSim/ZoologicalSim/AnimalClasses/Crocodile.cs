using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZoologicalSim.AnimalClasses
{
    public class Crocodile : Animal
    {
        // Constructor
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("crocodile.jpg");
        }
    }
}
