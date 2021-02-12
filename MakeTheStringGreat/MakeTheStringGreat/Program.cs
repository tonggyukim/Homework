using System;
using System.Text;

namespace MakeTheStringGreat
{
    class Solution
    {
        public string Checker(string str)
        {
            Stack s = new Stack<char>();
            for(int i = 0; i < str.Length; i++)
            {  char top = s.peek();
               if( !s.empty() &&  top != str[i] && top.upper() == str[i].upper())
               {   s.pop();
               }
               else
               {
                   s.push(str[i]);
               }
            }

// stack reverse return
string ans = String.Empty; 
while (!s.empty)
{. // prepend it to the ans. 
    ans
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Solution solution = new Solution();
            string greatString = solution.Checker(input);
            Console.WriteLine($"{greatString}");
            }
        }
    }
}
