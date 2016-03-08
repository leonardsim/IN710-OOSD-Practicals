using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Troll : Character
    {
        //Constructor
        public Troll(string name) : base(name)
        {
            this.name = name;
            weapon = new Knife();
        }
        //Methods
        public override string Declaim()
        {
            return "GET OUT NORMIES REEEEEEEEEEEEEEEEEEEE!";
        }
    }
}
