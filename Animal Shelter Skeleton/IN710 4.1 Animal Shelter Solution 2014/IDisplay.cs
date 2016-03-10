using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    interface IDisplay
    {
        void displayCritterList(List<Critter> critterList);
        void clearDisplay();
    }
}
