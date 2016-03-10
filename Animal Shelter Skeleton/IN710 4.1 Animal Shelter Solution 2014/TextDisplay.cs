using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {
        //Variables
        ListBox animalList;

        //Constructor
        public TextDisplay(ListBox animalList)
        {
            this.animalList = animalList;
        }


        //Methods
        // Displays the name and species of animal onto the listBox
        public void displayCritterList(List<Critter> critterList)
        {
            // foreach critter in the list ,add the name and sepcies to the listBox
            foreach (Critter c in critterList)
            {
                animalList.Items.Add(c.Name + ": " + c.Species);
            }
        }

        // Clear the listbox
        public void clearDisplay()
        {
            animalList.Items.Clear();
        }
    }
}
