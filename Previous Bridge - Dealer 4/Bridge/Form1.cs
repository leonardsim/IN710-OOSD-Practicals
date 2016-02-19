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
    public partial class Form1 : Form
    {
        private const int HANDS = 4;        // number of hands in a game of Bridge
        
        public Form1()
        {
            InitializeComponent();
            listBox1.Height = 850; // set the height of the listBox1
            
        }

        
        // creates the deck and deals out the 4 hands from the deck.
        private void button1_Click(object sender, EventArgs e)
        {
          TDeck myDeck = new TDeck();         // create and initialise a new TDeck
          THand[] myHand = new THand[HANDS];  // create and initialse a THand array
          listBox1.Items.Clear();             // clear the listBox
          myDeck.Shuffle();                   // shuffle the deckArray 

          // create the 4 handArrays, sort the handArrays and display them
          for (int i = 0; i < HANDS; i++)
          {
            myHand[i] = myDeck.dealHand(i);
            myHand[i].sortHand();
            myHand[i].printHand(listBox1);
          }
                 
        }

        
    }
}
