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
            // Set ship colour to be red
            shipColor = Color.FromArgb(255, 0, 0);

            // Declare brush and set the colour
            Brush brush = new SolidBrush(shipColor);

            // Draw the square ship
            shipCanvas.FillRectangle(brush, shipLocation.X, shipLocation.Y, SHIP_SIZE, SHIP_SIZE);
        }

        public void moveShip(Rectangle boundsRectangle)
        {
            // Changes the velocity direction by flipping the values (positive/negative)
            if (shipLocation.X >= (boundsRectangle.Width - SHIP_SIZE) || (shipLocation.X <= 1))
            {
                shipVelocity.X = shipVelocity.X - (shipVelocity.X * 2);
            }
            if (shipLocation.Y <= 1 || shipLocation.Y >= (boundsRectangle.Height - SHIP_SIZE))
            {
                shipVelocity.Y = shipVelocity.Y - (shipVelocity.Y * 2);
            }

            // Update the location of the ship so that it 'moves'
            shipLocation.X = shipLocation.X + shipVelocity.X;
            shipLocation.Y = shipLocation.Y + shipVelocity.Y;
        }

        public void OnFullOfFuelEvent()
        {

        }

        public void OnOutOfFuelEvent()
        {

        }

        public void refuel()
        {

        }

        public void ShipCycle(Rectangle boundsRectangle)
        {
            drawShip();
            moveShip(boundsRectangle);
        }

        public void usePetrol()
        {

        }
    }
}
