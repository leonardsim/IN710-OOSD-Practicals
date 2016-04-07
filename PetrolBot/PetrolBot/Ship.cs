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

        // Declare delegate
        public delegate void FuelEventHandler(object sender, ShipEventArgs e);

        // Declare events
        public event FuelEventHandler OutOfFuelEvent;
        public event FuelEventHandler FullOfFuelEvent;


        // Declare enum
        public enum EShipState { wandering, refueling }

        //Attributes
        Random rGen;
        Graphics shipCanvas;
        Color shipColor;
        Point shipLocation;
        Point shipVelocity;

        //Accessor
        public Point ShipLocation { get; set; }
        public int Petrol{ get;set; }

        //Constructor
        public Ship(Graphics shipCanvas, Random rGen)
        {
            this.shipCanvas = shipCanvas;
            this.rGen = rGen;

            // Set petrol value
            Petrol = rGen.Next(50, 101);

            // Set ship location
            // set fix position for now
            shipLocation = new Point(100 + rGen.Next(50), 100 + rGen.Next(50));

            // Set ship color as black
            shipColor = Color.FromArgb(0, 0, 0);

            // Set ship velocity
            shipVelocity = new Point(MIN_SPEED + rGen.Next(-MAX_SPEED, MAX_SPEED), MIN_SPEED + rGen.Next(-MAX_SPEED, MAX_SPEED));
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

            if (Petrol != 0)
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

                usePetrol();
            }
            else
            {

            }
        }

        public void OnFullOfFuelEvent()
        {
            ShipEventArgs e = new ShipEventArgs(shipLocation);

            if (FullOfFuelEvent != null)
            {
                FullOfFuelEvent(this, e);
            }
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs e = new ShipEventArgs(shipLocation);

            if (OutOfFuelEvent != null)
            {
                OutOfFuelEvent(this, e);
            }
        }

        public void refuel()
        {
            if (Petrol == 0)
            {
                while (Petrol != 255)
                {
                    Petrol++;
                }
            }
        }

        public void ShipCycle(Rectangle boundsRectangle)
        {
            drawShip();
            moveShip(boundsRectangle);
        }

        public void usePetrol()
        {
            if (Petrol != 0)
            {
                Petrol -= 1;
            }
        }
    }
}
