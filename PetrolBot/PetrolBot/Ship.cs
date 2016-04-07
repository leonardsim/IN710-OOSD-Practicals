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

        // Declare enum
        public enum EShipState { wandering, refueling }

        //Attributes
        int petrol;
        Point shipLocation;
        Random rGen;
        Graphics shipCanvas;
        Color shipColor;
        Point shipVelocity;

        //Constructor
        public Ship(Graphics shipCanvas, Random rGen)
        {
            this.shipCanvas = shipCanvas;
            this.rGen = rGen;

            // Set ship location
            // set fix position for now
            shipLocation = new Point(100, 100);

            // Set ship color;
            shipColor = Color.FromArgb(255, 0, 0);

            // Set ship velocity
            shipVelocity = new Point(rGen.Next(-2, 2), rGen.Next(-2, 2));
        }

    }
}
