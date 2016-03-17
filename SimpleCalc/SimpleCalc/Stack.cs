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
        public Dictionary<char, int> Constants { get; set; }

        public Stack()
        {
            Dictionary<char, int> Constants = new Dictionary<char, int>();
            this.Constants.Add('a', 5);
        }

        public void SetLastExp(object[] noodletest)
        {
            LastExp = noodletest;
        }
    }
}
