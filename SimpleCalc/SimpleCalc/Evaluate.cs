using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Evaluate
    {
        public Stack Stack = new Stack();

        public double EvalMath(object[] mathParty)
        {
            this.Stack.SetLastExp(mathParty);
            char operators = (char)mathParty[1];
            if (operators == '=')
            {
                return (int)mathParty[2];
            }
            else if (operators == '+')
            {
                var result = AddTwoNumbers(mathParty);
                Stack.LastAns = result;
                return result;
            }
            else if (operators == '-')
            {
                var result = SubtractTwoNumbers(mathParty);
                Stack.LastAns = result;
                return result;

            }
            else if (operators == '*')
            {
                var result = MultiplyTwoNumbers(mathParty);
                Stack.LastAns = result;
                return result;
            }
            else if (operators == '/')
            {
                var result = DivideTwoNumbers(mathParty);
                Stack.LastAns = result;
                return result;
            }
            else if (operators == '%')
            {
                var result = ModuloTwoNumbers(mathParty);
                Stack.LastAns = result;
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }


        public int AddTwoNumbers(object[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 + term2; 
            
        }

        public int SubtractTwoNumbers(object[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 - term2;
        }

        public int MultiplyTwoNumbers(object[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 * term2;
        }

        public double DivideTwoNumbers(object[] twoNums)
        {
            double term1 = (int)twoNums[0];
            double term2 = (int)twoNums[2];
            return term1 / term2;
        }

        public int ModuloTwoNumbers(object[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 % term2;
        }
    }
}
