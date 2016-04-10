using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{

    // Declare enum
    public enum EShipState { wandering, refueling }

    public class ShipEventArgs : EventArgs
    {
        //Attribute
        public Point ShipLocation {get; set;}
        EShipState state;

        //Constructor
        public ShipEventArgs(EShipState state)
        {
            this.state = state;
        }
    }
}
