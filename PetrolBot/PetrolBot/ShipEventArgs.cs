using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class ShipEventArgs : EventArgs
    {
        //Attribute
        public Point ShipLocation {get; set;}

        //Constructor
        public ShipEventArgs(Point ShipLocation)
        {
            this.ShipLocation = ShipLocation;
        }
    }
}
