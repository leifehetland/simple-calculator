using System;
using SimpleCalc;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void CanIStoreAnExpression()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            stack.SetLastExp(new object [] { 2, '+', 3});
            object [] actual = {2, '+', 3 };
            object[] expected = stack.LastExp;

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIStoreADouble()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            double expected = 5.569;
            stack.LastAns = 5.569;
            var actual = stack.LastAns;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIStoreAnInt()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            int expected = 5;
            stack.LastAns = 5;
            var actual = stack.LastAns;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanICreateAKeyValuePair()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            double expected = 5.569;
            stack.LastAns = 5.569;
            var actual = stack.LastAns;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
