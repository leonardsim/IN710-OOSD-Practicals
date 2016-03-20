using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class Memory
    {
        //Variables
        protected string name;
        protected string price;

        //Method
        public override string ToString()
        {
            return "$" + price + ", " + name;
        }

        //Getters/Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
