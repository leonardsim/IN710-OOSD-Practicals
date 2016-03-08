using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Queen : Character
    {
        //Constructor
        public Queen(string name) : base(name)
        {
            this.name = name;
            weapon = new Bow();
        }

        //Methods
        public override string Declaim()
        {
            return "I am the powerful Queen!";
        }
    }
}
