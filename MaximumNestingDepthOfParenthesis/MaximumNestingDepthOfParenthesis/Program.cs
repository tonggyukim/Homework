using System;

namespace MaximumNestingDepthOfParenthesis
{
    class Program
    {
        public int MaxDepth (string s)
        {
            int depth = 0, maxDepth = 0;
            //foreach (char c in s.ToCharArray())
            for (int i=0; i<s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    depth++;
                    maxDepth = Math.Max(depth, maxDepth);
                }
                else if (c == ')')
                {
                    depth--;
                }
            }
            return maxDepth;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a valid parenthesis string: ");
            string input = Console.ReadLine();
            Program tool = new Program();
            int answer = tool.MaxDepth(input);
            Console.WriteLine($"{answer}");

        }
    }
}
