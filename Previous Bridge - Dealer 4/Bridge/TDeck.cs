using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bridge
{
    class TDeck
    { 
      private const int DECKSIZE = 52; // size of the deckArray
      private const int HANDSIZE = 13; // size of a handArray
      Random rand;                     // random generator

      private TCard[] deckArray;

      // constructor
      public TDeck()
      {
        deckArray = new TCard[DECKSIZE]; // initialise a new deckArray
        rand = new Random();             // initialise a new Random generator

        // populate deckArray, select the suit, then select the rank
        for (int i = 0; i < 4; i++)
        {
          for (int j = 0; j < HANDSIZE; j++)
          {
            TCard card = new TCard(i, j);  // suit, rank
            deckArray[(i * HANDSIZE) + j] = card;
          } // end j for loop
        } // end i for loop
      } // end constructor
      

      
      /*
       * pre - takes in a listbox
       * post - none
       */
      // print the deckArray
      public void Print(ListBox box)
      {
        for (int i = 0; i < DECKSIZE; i++)
        {
          box.Items.Add(deckArray[i].ToString());
        }
      }


      /*
       * pre - none
       * post - none
       */
      // shuffles the deckArray into total disarray
      public void Shuffle()
      {
        TCard tmpCard;  // temp TCard used for the swap
        int ind;        // index position

        for (int i = 0; i < DECKSIZE; i++)
        {
          // select another index position to be swapped with 
          // position i.
          ind = rand.Next(DECKSIZE);

          // swap positions
          tmpCard = deckArray[i];
          deckArray[i] = deckArray[ind];
          deckArray[ind] = tmpCard;
        }
      }

      /*
      * pre - takes in an integer
      * post - returns a THand
      */
      // create a handArray from the TCards in the deckArray
      public THand dealHand(int mySeat)
      {
        seat s = seat.NORTH; // default needed for some reason
        THand hand;          // THand handler??
        TCard[] handArray = new TCard[HANDSIZE];

        // determine the seat/position. North, South ,East or West
        switch (mySeat)
        {
          case 0:
            s = seat.NORTH;
            break;

          case 1:
            s = seat.EAST;
            break;

          case 2:
            s = seat.SOUTH;
            break;

          case 3:
            s = seat.SOUTH;
            break;
        }

        //int blah = (int)seat.North;  // just playing

        // create a new THand
        for (int i = 0; i < HANDSIZE; i++)
        {
          handArray[i] = deckArray[i + (mySeat * HANDSIZE)];
        }
        hand = new THand(handArray, s);
        return hand;
      } // end dealhand method

    } // end TDeck class
}
