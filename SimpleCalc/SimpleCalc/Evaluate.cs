using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Evaluate
    {
        public int AddTwoNumbers(object[] userinput)
        {
            int term1 = (int)userinput[0];
            int term2 = (int)userinput[2];
            return term1 + term2; 
            
        }

        public int SubtractTwoNumbers(object[] userinput)
        {
            int term1 = (int)userinput[0];
            int term2 = (int)userinput[2];
            return term1 - term2;
        }

        public int MultiplyTwoNumbers(object[] userinput)
        {
            int term1 = (int)userinput[0];
            int term2 = (int)userinput[2];
            return term1 * term2;
        }

        public double DivideTwoNumbers(object[] userinput)
        {
            double term1 = (int)userinput[0];
            double term2 = (int)userinput[2];
            return term1 / term2;
        }

        public int ModuloTwoNumbers(object[] userinput)
        {
            int term1 = (int)userinput[0];
            int term2 = (int)userinput[2];
            return term1 % term2;
        }
    }
}
