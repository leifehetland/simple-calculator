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
            string expected = "2+3";
            stack.lastq = "2+3";
            var actual = stack.lastq;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIStoreADouble()
        {
            //Arrange
            Stack stack = new Stack();

            //Act
            double expected = 5.569;
            stack.lastans = 5.569;
            var actual = stack.lastans;

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
            stack.lastans = 5;
            var actual = stack.lastans;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
