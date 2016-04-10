using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Knife : IWeapon
    {
        //Interface method
        public string useWeapon()
        {
            return "I'll shank u m80!";
        }
    }
}
