using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class Dingo : Animal
    {
        // Constructor
        public Dingo()
        {
            name = "Dingo";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("dingo.jpg");
        }
    }
}
