using System;
using System.Collections.Generic;
namespace DetermineIfStringHalvesAreAlike
{
    class Program
    {
        private bool Determinater (string input)
        {
            HashSet<char> vowels = new HashSet<char>() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string firstHalf = input.Substring(0, input.Length/2);
            string secondHalf = input.Substring(input.Length / 2, input.Length / 2);
            int count1 = 0;
            int count2 = 0;
                for (int i = 0; i < firstHalf.Length; i++)
            {
                if (vowels.Contains(firstHalf[i]))
                {
                    count1++;
                }
            }
                for (int i=0; i < secondHalf.Length; i++)
            {
                if (vowels.Contains(secondHalf[i]))
                {
                    count2++;
                }
            }
            if (count1 == count2)
            {
                return true;
            }
            return false; 
        }
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string input = Console.ReadLine();
            Program solution = new Program();
            Console.WriteLine(solution.Determinater(input));
        }
    }
}
