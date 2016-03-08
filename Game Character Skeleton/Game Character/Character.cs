using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        //Variables
        protected string name;
        protected IWeapon weapon;

        //Constructor
        public Character(string name)
        {
            this.name = name;
        }

        //Methods
        public virtual string StateName()
        {
            return "My name is " + name + "!";
        }

        public abstract string Declaim();
    }
}
