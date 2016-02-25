using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    // IComparable can sort custom objects
    // The IComparable<T> defines a generalzied comparison method that a value
    // type or class implements to create a type-specific comparison method for
    // ordering or sorting its instances

    // In this case Hand class implements IComparable<Hand>, which means a
    // Hand instance can be comapred with toher Hand instances
    public class Hand : IComparable<Hand>
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);

            CardsInHand.Sort();
        }

        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;

            return 0;
        }

        // Compares current instance with another object of the same type
        // and returns an integer that indicates whether the current instance
        // preces, follows, or occurs in the same position in the sort order
        // as the other object

        //  1 - if other came first
        //  0 - if it is the same position
        // -1 - if it came first
        public int CompareTo(Hand other)
        {
            // If it of type Hand then it will to the comparison
            if (other is Hand)
            {
                // Will return an int based on which Hand should be ordered first
                // This will sort in descending order

                return other.TotalHCP.CompareTo(this.TotalHCP);
            }
            throw new ArgumentException("Object is not a Hand");
        }
    }
}