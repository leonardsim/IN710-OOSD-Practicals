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
            ArrayStack stack = new ArrayStack(3);

            // Array size is 3 so pushing 4 times will cause the array to overflow
            stack.Push("a");
            stack.Push("a");
            stack.Push("a");
            stack.Push("a");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "Tried to pop an empty list")]
        public void Pop_PopEmptyList_ReturnExceptionHandler()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Popping an empty array 
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "Tried to peek an empty list")]
        public void Peek_PeekEmptyList_ReturnExceptionHandler()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Popping an empty array 
            stack.Peek();
        }

        [TestMethod]
        public void Push_PushAnElement_SuccessfulPush()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push an element
            stack.Push("Test");

            string expected = stack.StackString[0];
            string actual = "Test";

            //Check if the first element added is the same as actual
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_PopAnElement_SuccessfulPop()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push an element
            stack.Push("Test");
            stack.Push("Test");

            String expected = "The string 'Test' was removed from stack";
            String actual = stack.Pop();

            //Check if the pop properly outputs the correct feedback
            Assert.AreEqual(expected, actual);
        }
    }
}
