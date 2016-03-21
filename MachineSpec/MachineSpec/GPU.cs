using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSpec
{
    public class GPU
    {
        //Variables
        protected string name;
        protected double price;

        //Method
        public override string ToString()
        {
            return "$" + price + "\t" + name;
        }

        //Getters/Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
