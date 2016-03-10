using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        //Variables 
        List<PictureBox> animalPictures;

        //Constructor
        public PictureDisplay(List<PictureBox> animalPictures)
        {
            this.animalPictures = animalPictures;
        }

        //Methods
        // Displays the pictures of the animal onto the 4 picture boxes
        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                animalPictures[i].Image = Image.FromFile(critterList[i].ImageFileName);
            }
        }

        // Clears the picture boxes
        public void clearDisplay()
        {
            foreach (PictureBox p in animalPictures)
            {
                p.Image = null;
            }

        }
    }
}
