using System;
using System.Collections.Generic;

namespace isPathCrossing
{
    class Solution
    {
        public static bool pathCrossChecker(char [] path)
        {
            (int x, int y) current = (0, 0);

            HashSet<(int x, int y)> visited = new HashSet<(int, int)>();
            visited.Add((0, 0));

            foreach (char ch in path)
            {
                if (ch == 'N')
                {
                    current.y++;
                }
                else if (ch == 'S')
                {
                    current.y--;
                }
                else if (ch == 'E')
                {
                    current.x++;
                }
                else if (ch == 'W')
                {
                    current.x--;
                }
                else
                {
                    Console.WriteLine($"Invalid Input: {ch}");
                    return false;
                }

                if(!visited.Add(current))
                {
                    return true;
                }
            }

            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Path: ");
            string input = Console.ReadLine();
            char[] inputList = input.ToCharArray();
            bool answer = Solution.pathCrossChecker(inputList);
            Console.Write($"{answer}");

            
        }
    }
}
