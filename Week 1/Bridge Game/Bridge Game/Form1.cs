using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridge_Game
{
    public partial class Form1 : Form
    {
        //Constants
        const int PLAYER_NUM = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Deck mDeck = new Deck();
            Hand[] mHand = new Hand[PLAYER_NUM];

            mDeck.Shuffle();

            for (int i = 0; i < PLAYER_NUM; i++)
            {
                mHand[i] = mDeck.dealHands(i);
                mHand[i].displayHand(listBox1);
            }

        }
    }
}
