using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixMatch
{
    public partial class Form1 : Form
    {
        //Declare variable
        MonsterFactory monStr;
        IMonsterParts mFac;

        public Form1()
        {
            InitializeComponent();

            // Inititalise them 
            monStr = new MonsterFactory();
            mFac = new MonsterFactory();

            foreach(String m in monStr.MonstersStr)
            {
                cbHead.Items.Add(m);
                cbBody.Items.Add(m);
                cbLegs.Items.Add(m);

                // Bad design if Fairy gets removed
                if (m == "Fairy")
                {
                    cbHead.Text = m;
                    cbBody.Text = m;
                    cbLegs.Text = m;
                }
            }
        }

        private void btnMakeMonster_Click(object sender, EventArgs e)
        {
            // Takes the text from the combobox and use it to make sub class monster
            // call the monster's method to return a bitmap and set it to the pictureBox
            string head = cbHead.SelectedItem.ToString();
            Monster headMon = mFac.makeMonster(head);
            pbHead.Image = headMon.monsterHead();

            string body = cbBody.SelectedItem.ToString();
            Monster bodyMon = mFac.makeMonster(body);
            pbBody.Image = bodyMon.monsterBody();

            string legs = cbLegs.SelectedItem.ToString();
            Monster legsMon = mFac.makeMonster(legs);
            pbLegs.Image = legsMon.monsterLegs();

        }
    }
}
