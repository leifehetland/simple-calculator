using System;
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

    }
}
