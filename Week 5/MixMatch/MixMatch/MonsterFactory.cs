using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMatch
{
    public class MonsterFactory : IMonsterParts
    {
        List<string> monstersStr = new List<string>()
        {
            "Fairy",
            "Frankenstein",
            "Skeleton",
            "Vampire",
            "Werewolf",
            "Witch"
        };

        public Monster makeMonster(string type)
        {
            Monster currMon = null;

            switch (type)
            {
                case "Fairy":
                    currMon = new Fairy();
                    break;
                case "Frankenstein":
                    currMon = new Frankenstein();
                    break;
                case "Skeleton":
                    currMon = new Skeleton();
                    break;
                case "Vampire":
                    currMon = new Vampire();
                    break;
                case "Werewolf":
                    currMon = new Werewolf();
                    break;
                case "Witch":
                    currMon = new Witch();
                    break;
            }

            return currMon;
        }

        //Getters/Setters
        public List<string> MonstersStr
        {
            get { return monstersStr; }
            set { monstersStr = value; }
        }
    }
}
