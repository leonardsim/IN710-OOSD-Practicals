using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class King : Character
    {

        //Constructor
        public King(string name) : base(name)
        {
            this.name = name;
        }

        //Methods
        public override string Declaim()
        {
            return "I am the most mighty of Kings!";
        }
    }
}
