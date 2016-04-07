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
        //Const
        const int PETROL_SIZE = 10;

        //Attributes
        Graphics botCanvas;
        Color botColor;
        Point botStartingLocation;
        Point botCurrentLocation;
        Ship botShip;
        Point shipLocation;

        //Constructor
        public PetrolBot(Graphics botCanvas, Color botColor, Point botStartingLocation)
        {
            this.botCanvas = botCanvas;
            this.botColor = botColor;
            botCurrentLocation = botStartingLocation;


        }

        //Methods
        public void drawBot()
        {
            // Set brush colour
            Brush botBrush = new SolidBrush(botColor);

            botCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, PETROL_SIZE, PETROL_SIZE);
        }

        public void FullOfFuelEventHandler()
        {

        }

        public void OutOfFuelEventHandler()
        {

        }

    }
}
