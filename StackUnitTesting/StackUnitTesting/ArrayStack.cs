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
        //Variables
        String[] stackString;
        int countArray;

        //Constructor
        public ArrayStack(int arraySize)
        {
            stackString = new String[arraySize];
            countArray = 0;
        }

        //Methods
        public void Push(string newString) 
        {
            try
            {
                stackString[countArray] = newString;
                countArray++;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new System.IndexOutOfRangeException("The array has overflowed", e);
            }
        }

        public String Pop()
        {
            String recentElement = stackString[countArray - 1]; 
            try
            {
                stackString[--countArray] = null;

                return "The string '" + recentElement + "' was removed from stack";
            }
            catch (IndexOutOfRangeException e)
            {
                throw new System.IndexOutOfRangeException("Tried to pop an empty list", e);
            }
        }

        public String Peek()
        {
            String recentElement = stackString[countArray - 1];

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
            if (countArray == 0 && (stackString[countArray] == null || stackString[countArray] == ""))
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
