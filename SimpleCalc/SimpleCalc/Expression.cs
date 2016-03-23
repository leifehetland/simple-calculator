using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Expression
    {
        public Stack Constants { get; set; }

        public Expression()
        {
            Constants = new Stack();
        }
        public object[] GetParts(string expression)
        {
            
            try
            {
                var operands = this.GetTwoNumbers(expression);
                var ops = this.GetOperator(expression);
                object[] parts = { operands[0], ops, operands[1] };
                return parts;
            }
            catch (Exception) {  }
            try
            {
                var operands = expression.Split('=');
                int value;
                int.TryParse(operands[1], out value);
                char key = operands[0][0];
                Constants.SetConstant(key, value);
                return new object[] { };
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        public int[] GetTwoNumbers(string expression)
        {
            char[] operators = { '+', '-', '/', '*', '%' };
            string [] onlyInts = expression.Split(operators);
            List<int> myNumbers = new List<int>();

            foreach (var stringInt in onlyInts)
            {
                int number;
                try
                {
                    number = Int32.Parse(stringInt);
                }
                catch (Exception)
                {
                    try
                    {
                        number = Constants.GetConstant(stringInt[0]);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException();
                    }

                    
                }

                myNumbers.Add(number);
            }

            if (myNumbers.Count != 2)
            {
                throw new ArgumentException();
            }
            return myNumbers.ToArray();
        }

        public string GetOperator(string equation)
        {
            if (equation.Contains("+"))
            {
                return "+";
            }

            if (equation.Contains("-"))
            {
                return "-";
            }

            if (equation.Contains("*"))
            {
                return "*";
            }

            if (equation.Contains("/"))
            {
                return "/";
            }

            if (equation.Contains("%"))
            {
                return "%";
            }

            return equation;

        }
    }
}