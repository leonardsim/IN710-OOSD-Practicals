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
        public PetrolBot(Graphics botCanvas, Color botColor, Point botStartingLocation, Ship botShip)
        {
            this.botCanvas = botCanvas;
            this.botColor = botColor;
            this.botStartingLocation = botStartingLocation;
            this.botShip = botShip;
            botCurrentLocation = botStartingLocation;

            Ship.FuelEventHandler handler = new Ship.FuelEventHandler(OutOfFuelEventHandler);

            botShip.OutOfFuelEvent += handler;
        }

        //Methods
        public void drawBot()
        {
            // Set brush colour
            Brush botBrush = new SolidBrush(botColor);

            botCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, PETROL_SIZE, PETROL_SIZE);
        }

        public void FullOfFuelEventHandler(object sender, ShipEventArgs e)
        {

        }

        public void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            if (botShip.Petrol == 0)
            {
                botCurrentLocation.X = botShip.ShipLocation.X;
                botCurrentLocation.Y = botShip.ShipLocation.Y;

                botShip.refuel();
            }

            botCurrentLocation.X = botStartingLocation.X;
            botCurrentLocation.Y = botStartingLocation.Y;
        }

    }
}
