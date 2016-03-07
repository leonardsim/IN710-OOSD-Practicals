using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUnitTesting
{
    public class ArrayStack
    {
        //Constant
        const int ARRAY_SIZE = 5;

        //Variables
        String[] stackString;
        int countArray;

        //Constructor
        public ArrayStack()
        {
            stackString = new String[ARRAY_SIZE];
            countArray = -1;
        }

        //Methods
        public void Push(string newString)
        {
            countArray++;
            stackString[countArray] = newString;
        }

        public String Pop()
        {
            String recentElement = stackString[countArray]; 

            if(countArray == -1)
            {
                return "There are no elements to Pop";
            }
            else
            {
                countArray--;
                stackString[countArray] = null;

                return "The string '" + recentElement + "' was removed from stack";
            }
        }

        public String Peek()
        {
            String recentElement = stackString[countArray];

            if (countArray == -1)
            {
                return "There are no elements recently added";
            }
            else
            {
                return "The string '" + recentElement + "' was recently added to stack";
            }
        }

        //Get/Set methods
        public String[] StackString
        {
            get { return stackString; }
            set { stackString = value; }
        }

        public int CountArray
        {
            get { return countArray; }
            set { countArray = value; }
        }
    }
}
