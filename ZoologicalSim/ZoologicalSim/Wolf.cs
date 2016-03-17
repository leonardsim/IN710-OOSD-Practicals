using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZoologicalSim
{
    public class Wolf : Animal
    {
        //Constructor
        public Wolf()
        {
            name = "Wolf";
            family = "Carnivore";
            food = "Meat";
            image = new Bitmap("wolf.jpg");
        }
    }
}
