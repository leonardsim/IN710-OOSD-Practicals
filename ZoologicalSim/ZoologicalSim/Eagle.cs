using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZoologicalSim
{
    public class Eagle : Animal
    {
        //Constructor
        public Eagle()
        {
            name = "Eagle";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("eagle.jpg");
        }
    }
}
