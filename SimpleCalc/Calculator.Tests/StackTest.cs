﻿using System;
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
            object [] actual = stack.LastExp;
            object[] expected = { 2, '+', 3 };

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
        public void CanISetAndGetConstants()
        {
            // Arrange
            Expression expression = new Expression();
            Stack stack = new Stack();
            // Act
            expression.GetParts("x = 5");
            int expected = 5;
            int actual = expression.Constants.GetConstant('x'); 
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIAddWithAConstant()
        {
            // Arrange
            Expression expression = new Expression();
            Stack stack = new Stack();
            // Act
            expression.GetParts("x = 5");
            int expected = 5;
            int actual = Evaluate.('x');

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
