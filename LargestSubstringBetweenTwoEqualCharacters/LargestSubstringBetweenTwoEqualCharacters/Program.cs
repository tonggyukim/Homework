using System;
using System.Collections.Generic;

namespace LargestSubstringBetweenTwoEqualCharacters
{
    class Program
    {
        public int Search(string input)
        {
            Dictionary<char, int> indexAndValue= new Dictionary<char, int>();
            int maxLength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (indexAndValue.ContainsKey(input[i]))
                {
                    int currentLength = i - indexAndValue[input[i]] - 1;
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    //indexAndValue.Add(input[i], i);
                    indexAndValue[input[i]] = i;

                }
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string: ");
            string input = Console.ReadLine();
            Program tool = new Program();
            int answer = tool.Search(input);
            Console.WriteLine($"{answer}");
        }
    }
}
