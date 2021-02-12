using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using utility;

namespace PostfixEvaluation
{
    class Evaluator
    {
        // store string value in 'stringValue' variable

        //'Stack()' is inbuilt function from namespace 'System.Collections'
        // make a stack;
        //public string answer;
        //Stack stack = new Stack();
        //Stack<float> stack = new Stack<float>();

        //evaluation method
        //public float expression()
        public float postFixEvaluation (IList<string> tokens)
        {
            Stack<float> stack = new Stack<float>();

            for (int j = 0; j < tokens.Count; j++)
            {
                //String c = stringValue.Substring(j, 1);
                char c = tokens[j][0];
                if (c.Equals('*'))
                {
                    float a = stack.Pop();
                    float b = stack.Pop();
                    stack.Push(a*b);
                }
                else if (c.Equals('/'))
                {
                    float a = stack.Pop();
                    float b = stack.Pop();
                    stack.Push(b/a);
                }
                else if (c.Equals('+'))
                {
                    float a = stack.Pop();
                    float b = stack.Pop();
                    stack.Push(a+b);
                }
                else if (c.Equals('-'))
                {
                    float a = stack.Pop();
                    float b = stack.Pop();
                    stack.Push(b-a);
                }
                else
                {
                    stack.Push(Convert.ToInt32(tokens[j]));
                }
            }

            return stack.Pop();
        }

        

        static void Main(string[] args)
        {
            //compute.stringValue = ("34+93-*");
            Console.WriteLine("Enter an Infix expression: ");
            string input = Console.ReadLine();
            char[] tokens = { ' ' };
            //string[] inputList = input.Split(tokens, StringSplitOptions.RemoveEmptyEntries);
            string [] inputList = Regex.Split(input, @"(?=[+\-*\/)(])|(?<=[+\-*\/()])");
            InfixToPostfix postfixConverter = new InfixToPostfix();
            IList<string> postfix = postfixConverter.infixToPostfix(inputList);
            //Console.Write("Enter a postfix expression: ");
            //string input = Console.ReadLine();
            //strinping[] inputList = input.Sp lit(' ');
            Evaluator evaluate = new Evaluator();
            float floatAnswer = evaluate.postFixEvaluation(postfix);
            Console.WriteLine($"Postfix evaluation of {string.Join(" ", postfix)} is {floatAnswer}");





            //Console.WriteLine("postfix evaluation of " + compute.stringValue + " is " + compute.expression());
        }
    }
}