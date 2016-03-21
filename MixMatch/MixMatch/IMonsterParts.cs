using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMatch
{
    public interface IMonsterParts
    {
        Monster makeMonster(string type);
    }
}
