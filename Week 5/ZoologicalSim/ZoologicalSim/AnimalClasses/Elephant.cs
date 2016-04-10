using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class Elephant : Animal
    {
        // Constructor
        public Elephant()
        {
            name = "Elephant";
            family = "Herbivore";
            food = "Leaf";
            image = new Bitmap("elephant.jpg");
        }
    }
}
