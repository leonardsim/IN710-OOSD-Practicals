using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Bow : IWeapon
    {
        //Interface method
        public string useWeapon()
        {
            return "My arrows will put you down!";
        }
    }
}
