using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMatch
{
    public class Monster
    {
        //Variables
        protected string type;
        protected Bitmap picture;

        //Method
        public Bitmap monsterHead()
        {
            picture = new Bitmap(type + "_0");

            return picture;
        }

        public Bitmap monsterBody()
        {
            picture = new Bitmap(type + "_1");

            return picture;
        }

        public Bitmap monsterLegs()
        {
            picture = new Bitmap(type + "_2");

            return picture;
        }

        // Getters/Setters
        public Bitmap Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public string Type 
        {
            get { return type; }
            set { type = value; }
        }
    }
}
