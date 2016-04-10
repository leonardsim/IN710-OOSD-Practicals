using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Game
{
    class Deck
    {
        //Constants
        const int NUM_RANK = 13;
        const int NUM_HAND = 13;
        const int NUM_SUIT = 4;
        const int DECKSIZE = 52;

        //Variables
        Card[] deck;
        Random randGen;
        int deckIndex = 0;

        //Constructor
        public Deck()
        {
            deck = new Card[DECKSIZE];
            randGen = new Random();

            //Fill deck array
            for (int i = 0; i < NUM_SUIT; i++)
            {
                for (int j = 0; j < NUM_RANK; j++)
                {
                    deck[deckIndex] = new Card(j, i);
                    deckIndex++;
                }
            }
        }

        //Methods
        //Shuffles the deck
        public void Shuffle()
        {
            for (int i = deck.Length - 1; i > 0; --i)
            {
                int randInd = randGen.Next(i + 1);

                Card temp = deck[i];
                deck[i] = deck[randInd];
                deck[randInd] = temp;
            }
        }

        //Deal cards 
        public Hand dealHands(int players)
        {
            //Cards 
            Card[] handArray = new Card[NUM_HAND];
            Hand playerHand;
            Player playerPos = Player.NORTH;

            switch (players)
            {
                case 0:
                    playerPos = Player.NORTH;
                    break;
                case 1:
                    playerPos = Player.SOUTH;
                    break;
                case 2:
                    playerPos = Player.EAST;
                    break;
                case 3:
                    playerPos = Player.WEST;
                    break;
            }

            for (int i = 0; i < NUM_HAND; i++)
            {
                handArray[i] = deck[i + (players * NUM_HAND)];
            }

            playerHand = new Hand(handArray, playerPos);

            return playerHand;
        }
        public void printDeck(ListBox list)
        {
            for (int i = 0; i < DECKSIZE; i++)
            {
                list.Items.Add(deck[i].convertToString());
            }
        }
    }
}
