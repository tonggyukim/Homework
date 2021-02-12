using System;

namespace ShuffleArray
{
    class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            for (int i=0; i<n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[i + n];
            }
            return result;
            //int i = 0;
            //int j = n;
            //for (int h=0; h<result.Length; h+=2)
            //{
            //    result[h] = nums[i++];
            //    result[h + 1] = nums[j++];
            //}
            //return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array of numbers: ");
            string input = Console.ReadLine();
            string[] strList = input.Split(',',' ');
            int entries = strList.Length;
            if (strList.Length % 2 != 0)
            {
                Console.WriteLine("Error: You need to give a even number of entries");
                entries--;
                //return;

            }
            int[] intList = new int[entries];

            for (int i=0; i<entries; i++)
            {
                intList[i] = int.Parse(strList[i]);
            }

            int n = (int)intList.Length/2;
            Solution sol = new Solution();
            int[] answer = sol.Shuffle(intList, n);
            Console.Write("Shuffled Result: ");
            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write($"{answer[i]} ");
            }
            if (strList.Length % 2 != 0)
            {
                Console.Write(strList[strList.Length-1]);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
