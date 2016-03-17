using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class OrangUtan : Animal
    {
        // Constructor
        public OrangUtan()
        {
            name = "OrangUtan";
            family = "Herbivore";
            food = "Leaf";
            image = new Bitmap("orangutan.jpg");
        }
    }
}
