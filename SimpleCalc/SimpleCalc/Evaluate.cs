using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Evaluate
    {
        public int AddTwoNumbers(int[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[1];
            return term1 + term2; 
            
        }

        public int SubtractTwoNumbers(int[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 - term2;
        }

        public int MultiplyTwoNumbers(int[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 * term2;
        }

        public double DivideTwoNumbers(int[] twoNums)
        {
            double term1 = (int)twoNums[0];
            double term2 = (int)twoNums[2];
            return term1 / term2;
        }

        public int ModuloTwoNumbers(int[] twoNums)
        {
            int term1 = (int)twoNums[0];
            int term2 = (int)twoNums[2];
            return term1 % term2;
        }
    }
}
