using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVS2015
{
    public enum SuitValue : int
    {
        Spades, Hearts, Diamonds, Clubs
    }

    public enum RankValue : int
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }

    // Note the different ways to use the Property (get;set;) synntax feature
    public class Card : IComparable<Card>
    {
        // A read-write Property
        public SuitValue Suit {  get; set;}

        // A read-only Property
        private string shortRank;
        public String ShortRank
        {
            get
            {
                return shortRank;
            }
        }

        // A Property with logic on write (set)
        private RankValue rank;
        public RankValue Rank
        {
            get
            {
                return rank;
            }
 
            set
            {
                rank = value;
                switch (rank)
                {
                    case RankValue.Ace:
                        shortRank = "A";
                        break;
                    case RankValue.King:
                        shortRank = "K";
                        break;
                    case RankValue.Queen:
                        shortRank = "Q";
                        break;
                    case RankValue.Jack:
                        shortRank = "J";
                        break;
                    case RankValue.Ten:
                        shortRank = "T";
                        break;
                    default:
                        int rankOrdinalPosition = (int)rank;
                        shortRank = (rankOrdinalPosition + 2).ToString();
                        break;
                } // end switch
            } // end set
        }



        public int HCP
        {
            get; set;
        }

        public Card(SuitValue initSuit, RankValue initRank)
        {
            Suit = initSuit;
            Rank = initRank;

            HCP = 0;
            switch(Rank)
            {
                case RankValue.Ace:
                    HCP = 4;
                    break;
                case RankValue.King:
                    HCP = 3;
                    break;
                case RankValue.Queen:
                    HCP = 2;
                    break;
                case RankValue.Jack:
                    HCP = 1;
                    break;
            }

        }

        public override string ToString()
        {
            return (Rank.ToString() + " of " + Suit.ToString());
        }

        public int CompareTo(Card other)
        {
            if (other is Card)
            {
                return other.Rank.CompareTo(this.Rank);
            }
            throw new ArgumentException("Object is not a Card");
        }
    }
}
