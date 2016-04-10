using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ZoologicalSim.AnimalClasses
{
    public class Tiger : Animal
    {
        // Constructor
        public Tiger()
        {
            name = "Tiger";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("tiger.jpg");
        }
    }
}
