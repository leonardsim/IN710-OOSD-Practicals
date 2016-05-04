using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Art_Database_1
{
    public class Painting
    {
        public String Artist { set; get; }
        public String Title { set; get; }
        public String Method { set; get; }
        public int Year { set; get; }
        public int Width { set; get; }
        public int Height { set; get; }

        public override string ToString()
        {
            String outString = Artist + "\t\t" + Year + "\t\t" + Method + "\t\t" + Title;
            return outString;
        }
    }
}
