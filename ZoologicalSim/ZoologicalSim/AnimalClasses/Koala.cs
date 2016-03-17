using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class Koala : Animal
    {
        // Constructor
        public Koala()
        {
            name = "Koala";
            family = "Herbivore";
            food = "Leaf";
            image = new Bitmap("koala.jpg");
        }
    }
}
