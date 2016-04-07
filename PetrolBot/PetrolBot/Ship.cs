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
        const int SHIP_SIZE = 50;

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
            ShipLocation = new Point(100, 100);

            // Set ship color;
            shipColor = Color.FromArgb(255, 0, 0);

            // Set ship velocity
            shipVelocity = new Point(rGen.Next(-2, 2), rGen.Next(-2, 2));
        }

        //Method
        public void drawShip()
        {

        }

        public void moveShip()
        {

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

        public void ShipCycle()
        {

        }

        public void usePetrol()
        {

        }
    }
}
