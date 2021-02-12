using System;

namespace CanMakeArithmeticProgression
{
    class Solution
    {
        private void printArray (int[] intArray)
        {
             Console.WriteLine($"array:");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"{intArray[i]} ");
            }
            Console.WriteLine();
        }
        public bool CheckArithmeticProgression(int[] intArray)
        {
            Console.WriteLine("Before Reverse: ");
            printArray(intArray);
            Array.Reverse(intArray);
            Console.WriteLine("After Reverse: ");
            printArray(intArray);
            int difference = intArray[0] - intArray[1];
            for (int i = 1; i < intArray.Length - 1; i++)
            {
                if ((intArray[i] - intArray[i + 1]) != difference)
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array of numbers: ");
            string input = Console.ReadLine();
            string[] strList = input.Split(',', ' ');
            int entries = strList.Length;
            int[] intList = new int[entries];

            for (int i = 0; i < entries; i++)
            { 
                intList[i] = int.Parse(strList[i]);
            }
             Solution sol = new Solution();
            var answer = sol.CheckArithmeticProgression(intList);
                string text = answer ? "" : "not ";
                //if (answer)
                //    {
                //        int x = 30, y = 30;
                //        int g = x + (y * 10);
                //        string result = x > y ? "x is greater than y" :
                //        (x < y ? "x is less than y" :
                //            (x == y ? "x is equal to y" : "No result"));
                //    }
                Console.WriteLine($"The array is {text}arithmetic progression");

        }
    }
}
