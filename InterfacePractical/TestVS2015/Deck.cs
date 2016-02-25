using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Deck
    {
        private const int RankCount = 13;
        private const int SuitCount = 4;

        private Card[,] cards;

        // Note the casting from int to enum type
        public Deck()
        {
            cards = new Card[RankCount, SuitCount];

            for (int r = 0; r < RankCount; r++)
                for (int s = 0; s < SuitCount; s++)
                    cards[r, s] = new Card((SuitValue)s, (RankValue)r);
        } // end constructor

        // Returns a List<Hand> of the specified dimension.
        // Each hand populated randomly, without duplication (i.e. no card appears twice)
        public List<Hand> Deal(int handCount, int handLength)
        {
            // What error checking is missing here?

            List<Hand> dealtHands = new List<Hand>();

            // Used to insure each card appears only once in the deal
            bool[,] cardUsed = new bool[RankCount, SuitCount];
            Random rand = new Random();

            // Take time to make sure you understand the logic.
            // This is a very common algorithm pattern.
            for (int h = 0; h < handCount; h++)
            {
                Hand currentHand = new Hand();
                int cardCount = 0;

                while (cardCount < handLength)
                {
                    int nextCardRank = rand.Next(RankCount);
                    int nextCardSuit = rand.Next(SuitCount);

                    if (cardUsed[nextCardRank, nextCardSuit] == false)
                    {
                        currentHand.AddCard(cards[nextCardRank, nextCardSuit]);
                        cardUsed[nextCardRank, nextCardSuit] = true;
                        cardCount++;
                    }
                }
                currentHand.ComputeHCP();
                dealtHands.Add(currentHand);
            } // all hands dealt

            // Sorts the hands based on the HCP Value from highest to lowest
            dealtHands.Sort();

            return dealtHands;
        } // end Deal

    }
}
