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

        // Made async method to run it asynchronously 
        public async void OutOfFuelEventHandler(object sender, ShipEventArgs e)
        {
            // When petrol is 0, change state to refueling
            if (botShip.Petrol == 0)
            {
                botShip.ShipState = Ship.EShipState.refueling;

                // Set the refueler lcoation to be the same as the current ship location
                botCurrentLocation.X = botShip.ShipLocation.X;
                botCurrentLocation.Y = botShip.ShipLocation.Y;

                // While petrol is not full yet, call refuel method
                while(botShip.Petrol != 50)
                {
                    botShip.Refuel();
                    
                    // Delay the processing by 100ms
                    await Task.Delay(100);
                }

                // Change state back to wandering
                botShip.ShipState = Ship.EShipState.wandering;

                // Reset petrolBots to initital position
                botCurrentLocation.X = botStartingLocation.X;
                botCurrentLocation.Y = botStartingLocation.Y;
            }

        }

    }
}
