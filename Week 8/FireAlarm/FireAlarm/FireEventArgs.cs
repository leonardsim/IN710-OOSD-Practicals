using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    // Declare enum
    public enum EFireCategory { MINOR, SERIOUS, INFERNO };

    public class FireEventArgs : EventArgs
    {
        // Create enum accessor
        public EFireCategory FireCategory { get; set; }

        //Constructor
        public FireEventArgs(EFireCategory currentFireCategory)
        {
            FireCategory = currentFireCategory;
        }
    }
}
