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

        private void button1_Click(object sender, EventArgs e)
        {
            swapWeapons();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            outputBattle();
        }

        //Methods 
        // Adds character to the list and outputs to the listbox
        public void addCharacters()
        {
            //Declare character called classType
            Character classType;

            // Checks which one of the radio buttons has been checked
            // If no radio buttons has been clicked then a messageBox will appear
            if (rdKing.Checked)
            {
                classType = new King(txtName.Text);
                charactersList.Add(classType);
            }
            else if (rdQueen.Checked)
            {
                classType = new Queen(txtName.Text);
                charactersList.Add(classType);
            }
            else if (rdKnight.Checked)
            {
                classType = new Knight(txtName.Text);
                charactersList.Add(classType);
            }
            else if (rdTroll.Checked)
            {
                classType = new Troll(txtName.Text);
                charactersList.Add(classType);
            }
            else
            {
                MessageBox.Show("You have not selected any class type yet!");
            }

            // foreach through the list and add them to the checkedListBoxes with the character names
            foreach (Character chr in charactersList)
            {
                checkedListBox1.Items.Add(chr.Name);
                checkedListBox2.Items.Add(chr.Name);
            }

            setRadioButtonToFalse();
        }

        // Swaps the current character's weapon with another weapon
        public void swapWeapons()
        {
            // Loops through the checkedListBox2 and checks if any of the characters have been checked and the index is saved
            // the indexChecked (as an index) will be used in the charactersList list to change the weapon
            // If nothing was selected then a messagebox will appear
            foreach (int indexChecked in checkedListBox2.CheckedIndices)
            {
                if (rdSword.Checked)
                {
                    charactersList[indexChecked].Weapon = new Sword();
                }
                else if (rdBow.Checked)
                {
                    charactersList[indexChecked].Weapon = new Bow();
                }
                else if (rdKnife.Checked)
                {
                    charactersList[indexChecked].Weapon = new Knife();
                }
                else
                {
                    MessageBox.Show("None of the weapons have been selected!");
                }
            }
        }

        public void outputBattle()
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                listBox1.Items.Add(charactersList[indexChecked].StateName());
                listBox1.Items.Add(charactersList[indexChecked].Declaim());
                listBox1.Items.Add(charactersList[indexChecked].outputWeapon());
            }
        }
        
        public void setRadioButtonToFalse()
        {
            rdKing.Checked = false;
            rdQueen.Checked = false;
            rdKnight.Checked = false;
            rdTroll.Checked = false;
        }
    }
}
