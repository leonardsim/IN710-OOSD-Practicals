using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Game
{
    public enum Player : int { NORTH = 0, SOUTH, EAST, WEST};

    class Hand
    {
        //Constants
        const int NUM_HAND = 13;

        //Variables
        public Player player;
        Card[] handCards;
        int totalHCPVal;

        //Constructor
        public Hand(Card[] handCards, Player player)
        {
            this.handCards = handCards;
            this.player = player;
        }

        //Methods
        public int calculateTotalVal()
        {
            totalHCPVal = 0;

            for (int i = 0; i < NUM_HAND; i++)
            {
                switch (handCards[i].Rank)
                {
                    case 12:
                        totalHCPVal += 4;
                        break;
                    case 11:
                        totalHCPVal += 3;
                        break;
                    case 10:
                        totalHCPVal += 2;
                        break;
                    case 9:
                        totalHCPVal += 1;
                        break;
                }
            }

            return totalHCPVal;
        }

        public void displayHand(ListBox list)
        {
            list.Items.Add(player + ": "); 

            //Suit Strings
            string spade = "S:\t";
            string heart = "H:\t";
            string diamond = "D:\t";
            string club = "C:\t";

            for (int i = 0; i < NUM_HAND; i++)
            {
                switch(handCards[i].Suit)
                {
                    case 0:
                        spade += handCards[i].convertToString() + " ";
                        break;
                    case 1:
                        heart += handCards[i].convertToString() + " ";
                        break;
                    case 2:
                        diamond += handCards[i].convertToString() + " ";
                        break;
                    case 3:
                        club += handCards[i].convertToString() + " ";
                        break;
                }
            }

            list.Items.Add(spade);
            list.Items.Add(heart);
            list.Items.Add(diamond);
            list.Items.Add(club);
            list.Items.Add("");

            list.Items.Add("Total HCP: " + calculateTotalVal());
            list.Items.Add("***************************");
        }

        public int TotalHCPVal
        {
            get { return totalHCPVal; }
            set { totalHCPVal = value; }
        }
    }
}
