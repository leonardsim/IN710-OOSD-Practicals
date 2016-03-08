using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {
        //Declare list of characters
        List<Character> charactersList = new List<Character>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            addCharacters();
        }

        public void addCharacters()
        {
            Character classType;

            if (rdKing.Checked)
            {
                classType = new King(txtName.Text);
                charactersList.Add(classType);
            }
            if (rdQueen.Checked)
            {
                classType = new Queen(txtName.Text);
                charactersList.Add(classType);
            }
            if (rdKnight.Checked)
            {
                classType = new Knight(txtName.Text);
                charactersList.Add(classType);
            }
            if (rdTroll.Checked)
            {
                classType = new Troll(txtName.Text);
                charactersList.Add(classType);
            }

            foreach (Character chr in charactersList)
            {
                checkedListBox1.Items.Add(chr.Name);
                checkedListBox2.Items.Add(chr.Name);
            }
        }
    }
}
