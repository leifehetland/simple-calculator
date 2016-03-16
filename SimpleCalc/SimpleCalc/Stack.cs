using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Stack
    {
        public object [] LastExp { get; set; }
        public double LastAns { get; set; }
        public Dictionary<char, int> constants = new Dictionary<char, int>();

        public void SetLastExp(object[] noodletest)
        {
            LastExp = noodletest;
        }
    }
}
