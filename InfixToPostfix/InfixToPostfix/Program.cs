using System;
using System.Collections.Generic;

namespace InfixToPostfix
{
    class Program
    {
        Stack<string> stack = new Stack<string>();
        int[] answer;

        public string[] infixToPostfix(string[] tokens)
        {
            string[] postfix = new string[tokens.Length];
            Dictionary<char, int> precedence = new Dictionary<char, int>
            {
                {'+',1}, {'-',1}, {'*',2},{'/',2}
            };

            int k = 0;
            for (int j = 0; j < tokens.Length; j++)
            {
                //extracting first character from string
                char c = tokens[j][0];
                if (char.IsDigit(c))
                {
                    postfix[k++] = tokens[j];
                }
                else
                {
                    //switch (c)
                    //{
                    //    case '+':
                    //    case '-':
                    //if (stack.Count == 0 || (precedence[stack.Peek()[0]] < precedence[c]))
                    //{
                    //    stack.Push(c.ToString());
                    //}
                    while (stack.Count > 0 && precedence[stack.Peek()[0]] >= precedence[c])
                    {
                        postfix[k++] = stack.Pop();
                    }
                    stack.Push(c.ToString());

                    if (st)
                    //    break;
                    ////case '*';
                    ////case '/';
                    //    break;
                }
            }
            //while loop until empty, pop all operators from stack and put them in postfix
            while (stack.Count > 0)
            {
                postfix[k++] = stack.Pop();
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
        //return???
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Infix expression: ");
            string input = Console.ReadLine();
            char[] tokens = {' '};
            string[] inputList = input.Split(tokens,StringSplitOptions.RemoveEmptyEntries);
            Program compute = new Program();
            string[] answer = compute.infixToPostfix(inputList);
            Console.WriteLine($"Postfix evaluation of {input} is ");
            compute.dumpArray(answer);
        }
    }
}
