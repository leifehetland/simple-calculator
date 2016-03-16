﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class Expression
    {
        public int[] GetTwoNumbers(string expression)
        {
            char[] operators = { '+', '-', '/', '*', '%' };
            string [] onlyInts = expression.Split(operators);
            List<int> myNumbers = new List<int>();

            foreach (var stringInt in onlyInts)
            {
                int number = Int32.Parse(stringInt);
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