using System;

namespace RunningSumOf1DArray
{
    class Solution
    {
        public int [] runningSum(int [] input)
        {
            int sum = 0;
            int[] res = new int[input.Length];
            for (int i=0; i<input.Length; i++)
            {
                sum += input[i];
                res[i] = sum;
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            string rawInput = Console.ReadLine();
            string[] rawInputList = rawInput.Split(',', ' ');
            int[] convertedInputList = new int[rawInputList.Length];
            for (int i = 0; i < rawInputList.Length; i++)
            {
                convertedInputList[i] = int.Parse(rawInputList[i]);
            }
            Solution solution = new Solution();
            int[] answer = solution.runningSum(convertedInputList);
            

            for (int i = 0; i < answer.Length; i++)
            {
                if (i == answer.Length - 1)
                {
                    Console.WriteLine($"{answer[i]}");
                }
                else
                {
                    Console.Write($"{answer[i]},");
                }
            }
        }
    }
}
