using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public enum ESpecies { Cat, Dog, Rabbit, Duck };

    public class Critter
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { name = value; imageFileName = "images/" + name + ".jpg"; } 
        }

        private string imageFileName;
        public string ImageFileName 
        {
            get { return imageFileName; } 
        }

        public ESpecies Species { get; set; }

        public Critter(string name, ESpecies species)
        {
            this.name = name;
            Species = species;
            imageFileName = "images/" + name + ".jpg";
        }

        public override string ToString()
        {
            return name + ": " + Species.ToString();
        }
    }
}
