using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Evaluate
    {
        public double EvalMath(object[] mathParty)
        {
            char operators = (char)mathParty[1];
            if (operators == '=')
            {
                return (int)mathParty[2];
            }
            else if (operators == '+')
            {
                return AddTwoNumbers(mathParty);
            }
            else if (operators == '-')
            {
                return SubtractTwoNumbers(mathParty);
            }
            else if (operators == '*')
            {
                return MultiplyTwoNumbers(mathParty);
            }
            else if (operators == '/')
            {
                return DivideTwoNumbers(mathParty);
            }
            else if (operators == '%')
            {
                return ModuloTwoNumbers(mathParty);
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
