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

        //Constructor
        public PetrolBot(Graphics botCanvas, Color botColor, Point startLoc, Ship botShip)
        {
            this.botCanvas = botCanvas;
            this.botColor = botColor;
            this.botShip = botShip;
            botStartingLocation = startLoc;
            botCurrentLocation = botStartingLocation;

            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);

            botShip.OutOfFuelEvent += outOfFuelHandler;

            Ship.FullOfFuelEventHandler fullOfFuelHandler = new Ship.FullOfFuelEventHandler(FullOfFuelEventHandler);

            botShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        //Methods
        public void drawBot()
        {
            // Set brush colour
            Brush botBrush = new SolidBrush(botColor);

            botCanvas.FillEllipse(botBrush, botCurrentLocation.X, botCurrentLocation.Y, PETROL_SIZE, PETROL_SIZE);
        }

        public void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            // Reset petrolBots to initital position
            botCurrentLocation = botStartingLocation;
        }


        public void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            // Set the refueler lcoation to be the same as the current ship location
            botCurrentLocation = botShip.ShipLocation;

            botShip.Refuel();
        }

    }
}
