using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoologicalSim
{
    public abstract class Continent
    {
        //Constants
        public const int ANIMAL_SIM_COUNT = 4;

        //Variables
        protected ListBox displayBox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory; // Instantiated in children

        //Constructors
        public Continent(ListBox displayBox, Random rGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        //Method
        // Will display the animal picture and message
        public void runSimulation()
        {
            Animal currentAnimal;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                // Randomly select an animal type
                int animalChoice = rGen.Next(nAnimalTypes);

                // Use the factory
                currentAnimal = animalFactory.createAnimal(animalChoice);

                // Simulate the animal
                displayBox.Items.Add(currentAnimal.ToString());

                // Argument takes in the bitmap and the X,Y-coordinates
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120));
            }

        }
    }
}
