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
        // Will add string element into the array and will throw an exception handler 
        // when an element is added to a fully filled array
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

        // Removes an element from the array and returns feedback to the user
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

        // Outputs the most recently added element in the array
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

        // Returns the number of strings held in the array
        public int Count()
        {
            return countArray;
        }

        // Returns true or false based on whether the stack is empty or has elements in it
        public bool IsEmpty()
        {
            if (countArray == 0 && stackString[countArray] == null)
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
