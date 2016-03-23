using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class Stack
    {
        public string LastExpString {
            get
            {
                if (LastExp == null)
                {
                    return "";
                }
                return String.Concat(
                    this.LastExp[0].ToString(),
                    this.LastExp[1].ToString(),
                    this.LastExp[2].ToString()
                );
            }
        }
        public object [] LastExp { get; set; }
        public double LastAns { get; set; }
        public Dictionary<char, int> Constants { get; set; }

        public Stack()
        {
             this.Constants = new Dictionary<char, int>();
            
        }

        public void SetLastExp(object[] myLastExp)
        {
            LastExp = myLastExp;
        }

        public int GetConstant(char myConstant)
        {
            int Constant = 0;
            if (Constants.ContainsKey(myConstant))
            {
                if (!Constants.TryGetValue(myConstant, out Constant))
                {
                    throw new ArgumentException();
                }
            }
            return Constant;
        }

        public void SetConstant(char key, int value)
        {
            if (Constants.ContainsKey(key))
            {
                throw new ArgumentException();
            }
            Constants.Add(key, value);
        }
    }
}
