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
            Dictionary<char, int> Constants = new Dictionary<char, int>();
            
        }

        public void SetLastExp(object[] myLastExp)
        {
            LastExp = myLastExp;
        }

        public int GetConstant(char myConstant)
        {
            int constant = 0;
            if (Constants.ContainsKey(myConstant))
            {
                if (!Constants.TryGetValue(myConstant, out constant))
                {
                    throw new ArgumentException();
                }
            }
            return constant;
        }

        public object[] SetConstant(string userInput, string[] letter)
        {
            userInput = userInput.ToLower();
            int constantArray = userInput.IndexOfAny(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            if (constantArray == -1)
            {
                throw new ArgumentException();
            }
            char constantLower = char.ToLower(userInput[constantArray]);

            int myLetter;
            bool success = int.TryParse(letter[1], out myLetter);
            if (!success)
            {
                throw new ArgumentException();
            }

            Constants.Add(constantLower, myLetter);
            return new object[] { constantLower, myLetter };
        }
    }
}
