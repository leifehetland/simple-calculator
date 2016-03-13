using System;
using SimpleCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ExpressionCanICreateAnInstance()
        {
            //Arrange
            Expression CalcExpression = new Expression();

            //Assert
            Assert.IsNotNull(CalcExpression);

        }

        [TestMethod]
        public void ExpressionCanIExtractTwoNumbers()
        {
            //Arrange
            Expression CalcExpression = new Expression();

            //Act
            var expected = new int[] { 2, 3 };
            var actual = CalcExpression.GetTwoNumbers("2+3");

            //Assert
            CollectionAssert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void ExpressionCanIRemoveSpaces()
        {
            //Arrange
            Expression CalcExpression = new Expression();

            //Act
            var expected = new int[] { 2, 3 };
            var userinput = "2              +          3";
            var actual = CalcExpression.GetTwoNumbers(userinput);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ExpressionCanIHandleLetters()
        {
            //Arrange
            Expression calcExpression = new Expression();

            //Act
            string badInput = "a + 5";
            calcExpression.GetTwoNumbers(badInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanIHandleOnlyOneNumber()
        {
            //Arrange
            Expression calcExpression = new Expression();

            //Act
            string badInput = "1";
            calcExpression.GetTwoNumbers(badInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanIHandleMoreThanTwoNumbers()
        {
            //Arrange
            Expression calcExpression = new Expression();

            //Act
            string badInput = "1 + 3 + 4";
            calcExpression.GetTwoNumbers(badInput);
        }

        [TestMethod]
        public void CanIExtractAnOperator()
        {
            //Arrange
            Expression calcExpression = new Expression();

            //Act
            string actual = calcExpression.GetOperator("2 + 3");

        }


    }
}
