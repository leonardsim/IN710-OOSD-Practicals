using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            throw new NotImplementedException();
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
