using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Art_Database_1
{
    public class Artist
    {
        public String LastName { set; get; }
        public String FirstName { set; get; }
        public String Country { set; get; }
        public int YearOfBirth { set; get; }
        public int YearOfDeath { set; get; }

        public override string ToString()
        {
            return (FirstName + " " + LastName + "\t\t" + YearOfBirth + "-" + YearOfDeath 
                + "\t\t" + Country);
        }
    }
}
