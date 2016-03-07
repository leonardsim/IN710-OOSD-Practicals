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
        public void Push_FilledArrayStack_ReturnExceptionHandler()
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
        public void Pop_AnEmptyList_ReturnExceptionHandler()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Popping an empty array 
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "Tried to peek an empty list")]
        public void Peek_InEmptyList_ReturnExceptionHandler()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Popping an empty array 
            stack.Peek();
        }

        [TestMethod]
        public void Push_InElementIntoStack_SuccessfulPush()
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
        public void Pop_Element_ReturnProperFeedback()
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

        [TestMethod]
        public void Peek_OnlyOneLatestElement_ReturnProperFeedback()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push an element
            stack.Push("Test");

            String expected = "The string 'Test' was recently added to stack";
            String actual = stack.Peek();

            //Check if the peek properly outputs the correct feedback
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_IfElementIsLatest_ReturnProperFeedback()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push an element
            stack.Push("Test");
            stack.Push("Ayy");

            String expected = "The string 'Ayy' was recently added to stack";
            String actual = stack.Peek();

            //Check if the peek properly outputs the correct feedback
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_EmptyStack_ReturnNegativeOne()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            int expected = 0;
            int actual = stack.Count();

            // Checks if the stack is actually empty
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_ArrayStackWithItems_ReturnTwo()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push elements
            stack.Push("Test");
            stack.Push("Test");

            int expected = 2;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_ASingleFilledArray_ReturnProperFeedback()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push elements
            stack.Push("Test");

            String expected = "The string 'Test' was removed from stack";
            String actual = stack.Pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_FilledArrayThenEmptied_ReturnZero()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            // Push elements
            stack.Push("Test");
            stack.Push("Test");
            stack.Pop();
            stack.Pop();

            int expected = 0;
            int actual = stack.Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_EmptyStackArray_ReturnTrue()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            bool expected = true;
            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_StackArrayFull_ReturnFalse()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            stack.Push("Test");
            stack.Push("Test");

            bool expected = false;
            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_PeekMultiItems_CountRemainsTheSame()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            stack.Push("Test");
            stack.Push("Tong");

            int countBeforePeeking = stack.Count();

            stack.Peek();
            stack.Peek();

            int countAfterPeeking = stack.Count();

            Assert.AreEqual(countBeforePeeking, countAfterPeeking);
        }

        [TestMethod]
        public void IsEmpty_PopFullyStackArray_ReturnTrue()
        {
            // Create and initialise ArrayStack
            ArrayStack stack = new ArrayStack(2);

            stack.Push("Test");
            stack.Push("Test");

            stack.Pop();
            stack.Pop();

            bool expected = true;
            bool actual = stack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }
    }
}
