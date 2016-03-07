using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackUnitTesting
{
    public class ArrayStack
    {
        //Constant
        const int ARRAY_SIZE = 3;

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
            try
            {
                countArray++;
                stackString[countArray] = newString;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new System.IndexOutOfRangeException("The array has overflowed", e);
            }
        }

        public String Pop()
        {
            String recentElement = stackString[countArray]; 

            try
            {
                countArray--;
                stackString[countArray] = null;

                return "The string '" + recentElement + "' was removed from stack";
            }
            catch (IndexOutOfRangeException e)
            {
                throw new System.IndexOutOfRangeException("Tried to peek an empty list", e);
            }
        }

        public String Peek()
        {
            String recentElement = stackString[countArray];

            try
            {
                return "The string '" + recentElement + "' was recently added to stack";
            }
            catch (IndexOutOfRangeException e)
            {
                throw new System.IndexOutOfRangeException("Tried to peek an empty list", e);
            }
        }

        public int Count()
        {
            return countArray;
        }

        public bool IsEmpty()
        {
            if (countArray == -1 && (stackString[countArray] == null || stackString[countArray] == ""))
            {
                return true;
            }
            else
            {
                return false;
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
