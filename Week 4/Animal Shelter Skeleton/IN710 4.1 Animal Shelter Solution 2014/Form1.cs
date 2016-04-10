using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxList = new List<PictureBox>();

        CritterCatalogue mainCatalogue;
        IDisplay displayMachine;

        // Make in advance and swap. Could also create on the fly as needed
        PictureDisplay pictureDisplayMachine;
        TextDisplay textDisplayMachine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxList.Add(pictureBox1);
            pictureBoxList.Add(pictureBox2);
            pictureBoxList.Add(pictureBox3);
            pictureBoxList.Add(pictureBox4);

            mainCatalogue = new CritterCatalogue("animalList.txt");
            pictureDisplayMachine = new PictureDisplay(pictureBoxList);
            textDisplayMachine = new TextDisplay(listBox1);

            displayMachine = pictureDisplayMachine; // default
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clean up previous contents
            clearFormControls();

            // Determine which species the user wants (see code below)
            String speciesName = getCheckedSpecies();

            // Get a List of the relevant Critters from the catalogue
            // YOU WILL NEED TO WRITE THE CRITTERQUERY METHOD
            List<Critter> selectedCritters = mainCatalogue.CritterQuery(speciesName);
            int critterCount = selectedCritters.Count;

            if (critterCount > pictureBoxList.Count)
                displayMachine = textDisplayMachine;    // Will show images
            else
                displayMachine = pictureDisplayMachine; // Will print text

            // clear any old contents. Part of IDisplay, so the Form knows it will work
            displayMachine.clearDisplay();

            // Make the call here. Behaviour will depend on which strategy your
            // instance implements.
            displayMachine.displayCritterList(selectedCritters);

        } // end button click handler

        //================================================================================
        //================================================================================
        private string getCheckedSpecies()
        {
            // The default is Cat
            String speciesName = "Cat";

            // Find which radio button is checked. If none, fall back to default
            foreach (RadioButton rdo in groupBox1.Controls)
            {
                if (rdo.Checked)
                {
                    // Skip over the first three chars of the name, the "rdo" part
                    speciesName = rdo.Name.Substring(3);
                }
            }
            return speciesName;
        }

        //================================================================================
        private void clearFormControls()
        {
            listBox1.Items.Clear();
            foreach (PictureBox p in pictureBoxList)
                p.Image = null;
        }
    }
}
