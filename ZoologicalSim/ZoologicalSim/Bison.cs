using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZoologicalSim
{
    public class Bison : Animal
    {
        // Constructor
        public Bison()
        {
            name = "Bison";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("bison.jpg");
        }
    }
}
