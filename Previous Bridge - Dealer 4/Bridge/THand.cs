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
    public enum seat:int {NORTH = 0, EAST, SOUTH, WEST}; // 0,1,2,3
    
    class THand
    {
      private const int HANDSIZE = 13; // number of cards in a hand
      private TCard[] handArray;       // array to store the card face and values in
      public seat mySeat;              // seat enumerator for North, South, East, West hands
      private int hcp;                 // stores the High Card Point score

      // constructor
      public THand(TCard[] startHandArray, seat startSeat)
      {
        this.handArray = startHandArray;
        this.mySeat = startSeat;
      }


      /*
       * pre - none
       * post - returns an integer
       */
      // set and get methods for the High Card Points
      public int HCP
      {
        get
        {
          return hcp;
        }

        set
        {
          hcp = value;
        }
      }

      
      /*
       * pre - takes in a a listBox
       * post - none
       */
      // prints out the seat position.
      // iterates through the handArrays and prints out the 
      // card face and value.
      // print out the HCP of each seat.

      //Revised
      public void printHand(ListBox box)
      {
        // print the seat position, e.g. NORTH, SOUTH, EAST, WEST
        box.Items.Add(mySeat + ":");

        //Added Suit strings
        string spades = "S:\t";
        string hearts = "H:\t";
        string diamonds = "D:\t";
        string clubs = "C:\t";

        // print the card face and value
        for (int i = 0; i < HANDSIZE; i++)
        {
          //Have 4 'if' statements that check the Suit int and then concat it to the Suit strings
          if(handArray[i].Suit == 0)
          {
              clubs += handArray[i].ToString() + " ";
          }
          if (handArray[i].Suit == 1)
          {
              diamonds += handArray[i].ToString() + " ";
          }
          if (handArray[i].Suit == 2)
          {
              hearts += handArray[i].ToString() + " ";
          }
          if (handArray[i].Suit == 3)
          {
              spades += handArray[i].ToString() + " ";
          }

          //box.Items.Add(handArray[i].ToString());
        }
        //Print out all 4 suit and their ranks
        box.Items.Add(spades);
        box.Items.Add(hearts);
        box.Items.Add(diamonds);
        box.Items.Add(clubs);

        box.Items.Add("High Card Point Total: " + getHCP());
        box.Items.Add(" ----------------- ");

      }


      /*
       * pre - none
       * post - returns an integer
       */
      // calculates the High Card Points for each hand
      //  and returns it
      public int getHCP()
      {
        // reset the hcp value
        hcp = 0; 
 
        // calculate the 
        for(int i = 0; i < HANDSIZE; i++)
        {
          // if it's an Ace
          if (handArray[i].Rank == 12)
            hcp += 4;

          // if it's a King
          if (handArray[i].Rank == 11)
            hcp += 3;

          // if it's a Queen
          if (handArray[i].Rank == 10)
            hcp += 2;

          // if it's a Jack
          if (handArray[i].Rank == 9)
            hcp += 1;

        }
        return hcp;
      }


      /*
       * pre - none
       * post - none
       */
      // Sorts each handArray according to it's Suit - Spades, Hearts, Diamonds then Clubs.
      // and Rank - Ace, King, Queen, Jack, 10 down to 2.
      public void sortHand()
      {
        // loop condition operator
        bool sorted = false;

        // while the handArray is not sorted loop through again
        while (!sorted)
        {
          sorted = true;

          // only go as far as the second last index since we are checking against the next
          // index value of the handArray with the current index value in the if statement.
          for (int i = 0; i < HANDSIZE -1; i++)
          {
            // e.g. if the current index suit is a 0 - a Club - and the next one is 3 - an Ace -
            // then swap them around.
            if (handArray[i].Suit < handArray[i + 1].Suit)
            {
              swap(i, i + 1);

              // set to false as there is more checking to do
              sorted = false;
            } // end if

            // if the Suit values are the same then check the ranks values
            // so the cards can be organised according to the rank. Ace down through
            // to 2.
            if (handArray[i].Suit == handArray[i + 1].Suit)
            {
              // e.g. if the current index rank is 10 - Jack, and the next index rank is
              // an 14 - Ace, then swap them around.
              if (handArray[i].Rank < handArray[i + 1].Rank)
              {
                swap(i, i + 1);
                sorted = false;
              } // end if
            } // end if
          } // end for loop
        } // end while 
      } // end sortHand method


      /*
       * pre - takes in 2 integer values
       * post - none
       */
      // swaps to index values around within the handArray
      public void swap(int i, int j)
      {
        // temporary TCard to hold a TCard value that is being swapped
        TCard tmpCard;

        tmpCard = handArray[i];
        handArray[i] = handArray[j];
        handArray[j] = tmpCard;
      } // end swap method

    }
}
