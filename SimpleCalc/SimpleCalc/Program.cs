﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Calculator, please give me a simple math problem.");
            Expression expression = new Expression();
            Evaluate evaluate = new Evaluate();
             
            while(true)
            {
                string input = Console.ReadLine();
                if(input == "quit" || input == "")
                {
                    break;
                }
                if (input == "last")
                {
                    double last = evaluate.Stack.LastAns;
                    Console.WriteLine(last);
                }
                else if (input == "lastq")
                {
                    string lastq = evaluate.Stack.LastExpString;
                    Console.WriteLine(lastq);
                }

                else
                {
                    object[] parts = expression.GetParts(input);
                    double results = evaluate.EvalMath(parts);
                    Console.WriteLine(results);
                }
            }

        }
    }
}
