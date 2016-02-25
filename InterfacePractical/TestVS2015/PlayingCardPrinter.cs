using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVS2015
{
    // This class reduces coupling between the logic (the deck) and the 
    // UI (the visible display; the Form)
    public class PlayingCardPrinter
    {
        public PlayingCardPrinter()
        {

        }

     
        public void PrintDeal(ListBox displayBox, List<Hand> hands)
        {   
            foreach (Hand h in hands)
            {
                PrintHand(displayBox, h);
                displayBox.Items.Add("------------------------------------------");
            }
        }

        public void PrintHand(ListBox displayBox, Hand handToPrint)
        {
            String spadeString = "S:\t";
            String heartString = "H:\t";
            String diamondString = "D:\t";
            String clubString = "C:\t";

            // Remember the ShortRank data member in the Card class?
            // Here's where we use it...
            foreach(Card c in handToPrint.CardsInHand)
            {
                switch(c.Suit)
                {
                    case SuitValue.Spades:
                        spadeString += c.ShortRank + " ";
                        break;
                    case SuitValue.Hearts:
                        heartString += c.ShortRank + " ";
                        break;
                    case SuitValue.Diamonds:
                        diamondString += c.ShortRank + " ";
                        break;
                    case SuitValue.Clubs:
                        clubString += c.ShortRank + " ";
                        break;
                }
            }

            displayBox.Items.Add(spadeString);
            displayBox.Items.Add(heartString);
            displayBox.Items.Add(diamondString);
            displayBox.Items.Add(clubString);

            int hcp = handToPrint.TotalHCP;
            displayBox.Items.Add("HCP: " + hcp);
        }
    }
}
