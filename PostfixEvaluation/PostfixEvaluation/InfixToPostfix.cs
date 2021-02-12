using System;
using System.Collections.Generic;

namespace utility
{
    class InfixToPostfix
    {
        Stack<string> stack = new Stack<string>();  

        public IList<string> infixToPostfix(string[] tokens)
        {
            IList<string> postfix = new List<string>();
            Dictionary<char, int> precedence = new Dictionary<char, int>
            {
                {'(', 0 }, {'+',1}, {'-',1}, {'*',2},{'/',2}
            };

            //int k = 0;
            for (int j = 0; j < tokens.Length; j++)
            {
                string token = tokens[j].Trim();
                if (token.Length == 0)
                {
                    continue;
                }

                //extracting first character from string
                char c = token[0];
                if (char.IsDigit(c))
                {
                    postfix.Add(token);
                }
                else
                {
                    if (c == '(')
                    {
                        stack.Push(c.ToString());
                    }
                    //switch (c)
                    //{
                    //    case '+':
                    //    case '-':
                    //if (stack.Count == 0 || (precedence[stack.Peek()[0]] < precedence[c]))
                    //{
                    //    stack.Push(c.ToString());
                    //}
                    else if (c == ')')
                    {
                        while (stack.Peek() != "(")
                        {
                            postfix.Add(stack.Pop());
                        }
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && precedence[stack.Peek()[0]] >= precedence[c])
                        {
                            postfix.Add(stack.Pop());
                        }
                        stack.Push(c.ToString());
                        //    break;
                        ////case '*';
                        ////case '/';
                        //    break;
                    }
                }
            }
            //while loop until empty, pop all operators from stack and put them in postfix
            while (stack.Count > 0)
            {
                postfix.Add(stack.Pop());
            }
            return postfix;
        }
        private void dumpArray(string[] strList)
        {
            foreach(var token in strList)
            {
                Console.Write(" " + token.ToString());
            }
            Console.WriteLine();
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter an Infix expression: ");
        //    string input = Console.ReadLine();
        //    char[] tokens = {' '};
        //    string[] inputList = input.Split(tokens,StringSplitOptions.RemoveEmptyEntries);
        //    Program compute = new Program();
        //    string[] answer = compute.infixToPostfix(inputList);
        //    Console.WriteLine($"Postfix evaluation of {input} is ");
        //    compute.dumpArray(answer);
        //}
    }
}
