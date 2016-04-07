using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class PetrolBot
    {
        //Attributes
        Graphics botCanvas;
        Color botColor;
        Point botStartingLocation;
        Point botCurrentLocation;
        Ship botShip;
        Point shipLocation;

        //Constructor
        public PetrolBot(Graphics botCanvas, Color botColor, Ship botShip)
        {
            this.botCanvas = botCanvas;
            this.botColor = botColor;
            this.botShip = botShip;
        }

        //Methods
        public void drawBot()
        {

        }

        public void FullOfFuelEventHandler()
        {

        }

        public void OutOfFuelEventHandler()
        {

        }

    }
}
