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
            // Add to empty list
            if (headPointer == null)
            {
                // Both head and tail pointer point to the new single pellet
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                // The newPellet will be added to the Next of tail (making a new node) and the pointer will point to that node now
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            // Create count to keep track of how many pellets there are
            // Assign the pelletWalker to reference the same pellet as headPointer
            int count = 0;
            Pellet pelletWalker = headPointer;

            // if the pelletWalker has not reached the end of the list then increment the count and set the
            // pelletWalker to point to the next pellet in the list
            while (pelletWalker != null)
            {
                count++;
                pelletWalker = pelletWalker.Next;
            }

            return count;
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
