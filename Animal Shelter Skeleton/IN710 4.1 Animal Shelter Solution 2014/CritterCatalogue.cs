using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class CritterCatalogue
    {
        string inputFileName;
        private List<Critter> critterList;

        //=======================================================================
        // Ctor
        //=======================================================================
        public CritterCatalogue(string inputFileName)
        {
            this.inputFileName = inputFileName;
            critterList = new List<Critter>();
            loadCritterList();
        }

        //=======================================================================
        // Returns a List<Critter> containing all Critters in class member 
        // critterList whose species is equal to the passed in argument.
        // NB: Critter.species is an enum; the passed in argument is a string.
        // Explore System.Enum.Parse for solution.
        //=======================================================================
        public List<Critter> CritterQuery(string speciesName)
        {
            // Declare and initialise a new Critter List
            List<Critter> cL = new List<Critter>();

            // Parse string speciesName into an enum
            ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), speciesName);

            // foreach through each critter in critterList and if the species in critter matches the currentSpecies
            // then add critter into cL list
            foreach (Critter c in critterList)
            {
                if (c.Species == currentSpecies)
                {
                    cL.Add(c);
                }
            }

            //return the list
            return cL;
        }


        //=======================================================================
        // Reads in and parses the text file.
        // Creates a Critter instance for each entry, and loads them into the
        // class member List<Critter> critterList
        //=======================================================================
        private void loadCritterList()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(inputFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find the input file!");
            }

            if (sr != null)
            {
                String currentLine = "";
                String[] currentAnimal;


                while ((currentLine = sr.ReadLine()) != null)
                {
                    // Split it at the ','
                    // currentAnimal[0] = animal name
                    // currentAnimal[1] = species
                    currentAnimal = currentLine.Split(',');

                    // Convert to enum ESpecies
                    ESpecies currentSpecies = (ESpecies)System.Enum.Parse(typeof(ESpecies), currentAnimal[1]);

                    //Save to list
                    critterList.Add(new Critter(currentAnimal[0], currentSpecies));
                } // end for each line
            } // end if sr != null
        } // end loadCritterList

        //=======================================================================
        // Prints critterList to the paseed-in ListBox
        //=======================================================================
        public void PrintAllCritters(ListBox displayBox)
        {
            displayBox.Items.Clear();
            foreach (Critter c in critterList)
            {
                displayBox.Items.Add(c.ToString());
            }
        }

       

    }
}
