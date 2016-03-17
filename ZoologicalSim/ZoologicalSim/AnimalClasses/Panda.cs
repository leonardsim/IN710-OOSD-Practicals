using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class Panda : Animal
    {
        // Constructor
        public Panda()
        {
            name = "Koala";
            family = "Omnivore";
            food = "Leaf & Meat";
            image = new Bitmap("panda.jpg");
        }
    }
}
