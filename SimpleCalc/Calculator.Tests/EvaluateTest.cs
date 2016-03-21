using System;
using SimpleCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void CanIAddTwoNumbers()
        {
            //Arrange
            Evaluate evaluate = new Evaluate();

            //Act
            int expected = 5;
            object[] userInput = { 2, "+", 3 } ;
            double actual = evaluate.EvalMath(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanISubtractTwoNumbers()
        {
            //Arrange
            Evaluate Subtract = new Evaluate();

            //Act
            var expected = 1;
            object[] userInput = { 3, "-", 2 };
            double actual = Subtract.EvalMath(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIMultiplyTwoNumbers()
        {
            //Arrange
            Evaluate Multiply = new Evaluate();

            //Act
            var expected = 10;
            object[] userInput = { 2, "*", 5 };
            double actual = Multiply.EvalMath(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIDivideTwoNumbers()
        {
            //Arrange
            Evaluate Division = new Evaluate();

            //Act
            var expected = .25;
            object[] userInput = { 1, "/", 4 };
            double actual = Division.EvalMath(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIModuloNumbers()
        {
            //Arrange
            Evaluate Modulo = new Evaluate();

            //Act
            var expected = 2;
            object[] userInput = { 11, "%", 3 };
            double actual = Modulo.EvalMath(userInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIParseTwoNumbers()
        {
            //Arrange
            Evaluate math = new Evaluate();
            Expression myExpression = new Expression();
            string testExpression = "4*2";
            int[] twoNums = myExpression.GetTwoNumbers(testExpression);


            //Act
            int[] expected = { 4, 2 };
            int[] actual = twoNums;

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIParseAnOperator()
        {
            //Arrange
            Evaluate math = new Evaluate();
            Expression myExpression = new Expression();
            string testExpression = "4*2";
            string myOperator = myExpression.GetOperator(testExpression);



            //Act
            string expected = ("*");
            string actual = myOperator;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void CanIHandleMoreThanTwoOperators()
        {
            //Arrange
            Evaluate calcEval = new Evaluate();

            //Act
            object [] badInput = { 1, '+', '/', 4 };
            calcEval.EvalMath(badInput);
        }

        [TestMethod]
        public void CanIHandleSetLastExpression()
        {
            //Arrange
            Evaluate calcEval = new Evaluate();
            object[] expression = { 4, "-", 2 };

            //Act
            calcEval.EvalMath(expression);
            var actual = calcEval.Stack.LastExp;

            //Assert
            CollectionAssert.AreEqual(actual, expression);
              
        }

        [TestMethod]
        public void CanIHandleSetLastAnswer()
        {
            //Arrange
            Evaluate calcEval = new Evaluate();
            object[] expression = { 4, "-", 2 };
            double expected = 2;

            //Act
            calcEval.EvalMath(expression);
            var actual = calcEval.Stack.LastAns;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CanIHandleSetLastAnswerOnMultipleCalculations()
        {
            //Arrange
            Evaluate calcEval = new Evaluate();
            object[] expression1 = { 4, "-", 2 };
            object[] expression2 = { 2, "+", 3 };
            object[] expression3 = { 3, "*", 5 };

            object[] lastExpression  = expression3;
            double lastAnswer = 15;

            //Act
            calcEval.EvalMath(expression1);
            calcEval.EvalMath(expression2);
            calcEval.EvalMath(expression3);
            var actualAnswer = calcEval.Stack.LastAns;
            var actualExpression = calcEval.Stack.LastExp;

            //Assert
            CollectionAssert.AreEqual(actualExpression, lastExpression);
            Assert.AreEqual(actualAnswer, lastAnswer);
        }
    }
}
