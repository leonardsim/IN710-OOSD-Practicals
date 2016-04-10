using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class Ship
    {
        //Const
        const int SHIP_SIZE = 30;
        const int MIN_SPEED = 5;
        const int MAX_SPEED = 20; 

        // Declare delegate & events
        public delegate void OutOfFuelEventHandler(object sender, ShipEventArgs e);
        public event OutOfFuelEventHandler OutOfFuelEvent;

        public delegate void FullOfFuelEventHandler(object sender, ShipEventArgs e);
        public event FullOfFuelEventHandler FullOfFuelEvent;


        //Attributes
        Random rGen;
        Graphics shipCanvas;
        Color shipColor;
        Point shipLocation;
        Point shipVelocity;
        EShipState shipState;
        int pRand;


        //Accessor
        public EShipState ShipState
        {
            get { return shipState; }
            set { shipState = value; }
        }
        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }
        public int Petrol{ get;set; }

        //Constructor
        public Ship(Graphics shipCanvas, Random rGen)
        {
            this.shipCanvas = shipCanvas;
            this.rGen = rGen;

            // Set default state
            shipState = EShipState.wandering;

            // Set petrol value
            pRand = rGen.Next(50, 101);
            Petrol = pRand;

            // Set ship location
            // set fix position for now
            shipLocation = new Point(100 + rGen.Next(50), 100 + rGen.Next(50));

            // Set ship color as black
            shipColor = Color.FromArgb(0, 0, 0);

            // Set ship velocity
            // Make sure the no zero number gets generated
            int randNum = rGen.Next(MIN_SPEED, MAX_SPEED);
            shipVelocity = new Point(MIN_SPEED + rGen.Next(-randNum, randNum), MIN_SPEED + rGen.Next(-randNum, randNum));
        }

        //Method
        public void drawShip()
        {
            // Get the petrol ratio to determine what shade of red it will be
            double petrolRatio = Petrol / 100.0;
            double redValue = 255 * petrolRatio;

            // Set the shipColor to be that shade of red
            shipColor = Color.FromArgb((int)redValue, 0, 0);

            // Assign brush with that colour
            Brush shipBrush = new SolidBrush(shipColor);

            // Draw the square ship
            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, SHIP_SIZE, SHIP_SIZE);
        }

        public void moveShip(Rectangle boundsRectangle)
        {
            if (shipState == EShipState.wandering)
            {
                // Changes the velocity direction by flipping the values (positive/negative)
                if (shipLocation.X >= (boundsRectangle.Width - SHIP_SIZE * 2) || (shipLocation.X <= 1))
                {
                    shipVelocity.X = shipVelocity.X - (shipVelocity.X * 2);
                }
                if (shipLocation.Y <= 1 || shipLocation.Y > (boundsRectangle.Height - SHIP_SIZE))
                {
                    shipVelocity.Y = shipVelocity.Y - (shipVelocity.Y * 2);
                }

                // Update the location of the ship so that it 'moves'
                shipLocation.X = shipLocation.X + shipVelocity.X;
                shipLocation.Y = shipLocation.Y + shipVelocity.Y;

                // When location is updated, decrease the petrol value
                UsePetrol();
            }
        }

        public void OnFullOfFuelEvent()
        {
            ShipEventArgs e = new ShipEventArgs(shipState);

            if (FullOfFuelEvent != null)
                FullOfFuelEvent(this, e);
        }

        
        public void OnOutOfFuelEvent()
        {
            // Instantiate the custom event
            ShipEventArgs e = new ShipEventArgs(shipState);

            // Is null if no methods have been registered
            if (OutOfFuelEvent != null)
            {
                // Raises the event
                OutOfFuelEvent(this, e);
            }
        }

        // Increment the petrol value
        public void Refuel()
        {
            if (Petrol < 100)
            {
                Petrol++;
            }
        }

        // Calls the moveShip and drawShip methods
        public void ShipCycle(Rectangle boundsRectangle)
        {
            if (Petrol == 100)
            {
                shipState = EShipState.wandering;
                OnFullOfFuelEvent();
            }

            if (Petrol == 0)
            {
                shipState = EShipState.refueling;
            }

            if (shipState == EShipState.wandering)
            {
                drawShip();
                moveShip(boundsRectangle);
            }
            else
            {
                drawShip();
                OnOutOfFuelEvent();
            }
        }

        // Decrement the petrol value and when 0, set status to 'refueling'
        public void UsePetrol()
        {
            Petrol--;
        }
    }
}
