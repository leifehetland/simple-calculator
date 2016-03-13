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
            Evaluate Add = new Evaluate();

            //Act
            var expected = 5;
            object[] userinput = { 2, '+', 3};
            var actual = Add.AddTwoNumbers(userinput);

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
            object[] userinput = { 3, '-', 2 };
            var actual = Subtract.SubtractTwoNumbers(userinput);

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
            object[] userinput = { 2, '*', 5 };
            var actual = Multiply.MultiplyTwoNumbers(userinput);

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
            object[] userinput = { 1, '/', 4 };
            var actual = Division.DivideTwoNumbers(userinput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanIAddModuloNumbers()
        {
            //Arrange
            Evaluate Modulo = new Evaluate();

            //Act
            var expected = 2;
            object[] userinput = { 11, '%', 3 };
            var actual = Modulo.ModuloTwoNumbers(userinput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
