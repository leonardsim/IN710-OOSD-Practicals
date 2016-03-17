using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicalSim
{
    public class Animal
    {
        // Variables
        protected string name;
        protected string family;
        protected string food;
        private Bitmap image;

        // Methods
        public override string ToString()
        {
            string displayString = "I am " + name;
            displayString += ". I am a " + family;
            displayString += ". I eat " + food + ".";

            return displayString;
        }

        // Getter
        protected Bitmap Image
        {
            get { return image; } // read only
        }
    }
}
