using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUnitTesting;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "The array has overflowed")]
        public void Push_StackArrayOverflows_ReturnExceptionHandler()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack();

            // Array size is 3 so pushing 4 times will cause the array to overflow
            stack.Push("a");
            stack.Push("a");
            stack.Push("a");
            stack.Push("a");
        }
    }
}
