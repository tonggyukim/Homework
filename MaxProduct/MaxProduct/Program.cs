using System;

namespace Max
{
    class Solution
    {
        public static int MaxProduct(int[] nums)
        {
            //Array.Sort(nums);
            //return (nums[nums.Length - 1] - 1) * (nums[nums.Length - 2] - 1);
            var max = (nums[0] - 1) * (nums[1] - 1);
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    max = Math.Max(max, (nums[i] - 1) * (nums[j] - 1));
            return max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a List of Numbers: ");
            string stringNums = Console.ReadLine();
            char[] seperator = { ',', ' ' };
            string[] stringNumsList = stringNums.Split(seperator);
            int[] intNumsList = new int[stringNumsList.Length];

            for (int i = 0; i < intNumsList.Length; i++)
            {
                intNumsList[i] = int.Parse(stringNumsList[i]);
            }

            //Solution solution = new Solution();
            int answer = Solution.MaxProduct(intNumsList);

            Console.WriteLine($"{answer}");
              
        }
    }
}
