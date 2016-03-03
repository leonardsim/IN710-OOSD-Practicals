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
            // Assign the pelletWalker to reference the same pellet as headPointer
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                pelletWalker.Move();
                pelletWalker = pelletWalker.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            // Assign the pelletWalker to reference the same pellet as headPointer
            Pellet pelletWalker = headPointer;

            while (pelletWalker != null)
            {
                // When pelletWalker goes out of bound, the bool alive property is set to false
                if (pelletWalker.TestOutOfBounds(boundsRectangle) == true)
                {
                    pelletWalker.IsAlive = false;
                }

                // Set next pellet to be the pelletWalker
                pelletWalker = pelletWalker.Next; 
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            // Assign the pelletWalker to reference the same pellet as headPointer
            Pellet pelletWalker = headPointer;

            // Checks if the pelletWalker and pelletToDelete points to the same pellet
            if (headPointer == pelletToDelete)
            {
                // Check if the next one on the list is null
                // If it is then there is only one Pellet left in the List and headPointer and tailPointer will be set to null
                if (pelletWalker.Next == null)
                {
                    headPointer = null;
                    tailPointer = null;
                }
                else
                {
                    // Set the second pellet in List to be the headPointer
                    headPointer = pelletWalker.Next;
                }
            }
            else
            {
                // Will loop through if pelletWalker.Next does not equal to pelletToDelete
                // and have pelletWalker traverse along the List until it points to the pelletToDelete
                while(pelletWalker.Next != pelletToDelete)
                {
                    pelletWalker = pelletWalker.Next; 
                }

                // When out of the loop, the pelletWalker.Next = pelletToDelete 
                // the next pellet of the pelletToDelete will be saved into the next pellet of pelletWalker (which is pelletToDelete)
                // so the pellet next to pelletToDelete will now take the place of pelletToDelete
                pelletWalker.Next = pelletToDelete.Next;

                // Checks if the next pellet is at the end of the List
                // if it is then set current pellet (pelletWalker) to tailPointer
                if (pelletWalker.Next == null)
                {
                    tailPointer = pelletWalker;
                }
            }
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
