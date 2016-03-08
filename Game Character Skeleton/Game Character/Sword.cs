using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Sword : IWeapon
    {
        //Interface method
        public string useWeapon()
        {
            return "I will slash you down with my weaboo slasher!";
        }
    }
}
