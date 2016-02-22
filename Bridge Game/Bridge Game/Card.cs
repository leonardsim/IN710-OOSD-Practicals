using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Game
{
    class Card
    {
        //Variables
        int rank;
        int suit;

        //Constructor
        public Card(int rank, int suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        //Methods
        //Gets and Sets
        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public int Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public string convertToString()
        {
            String rankString = (rank + 2).ToString();

            switch (rankString)
            {
                case "14":
                    rankString = "A";
                    break;
                case "13":
                    rankString = "K";
                    break;
                case "12":
                    rankString = "Q";
                    break;
                case "11":
                    rankString = "J";
                    break;
                case "10":
                    rankString = "T";
                    break;
            }

            return rankString;
        }
    }
}
