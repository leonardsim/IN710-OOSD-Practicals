using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZoologicalSim.AnimalClasses
{
    public class Bear : Animal
    {
        //Constructor
        public Bear()
        {
            name = "Bear";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("bear.jpg");
        }
    }
}
