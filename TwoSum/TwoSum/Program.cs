using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complimentIndex = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (complimentIndex.ContainsKey(nums[i]))
                {
                    return new int[] { complimentIndex[nums[i]], i };
                }
                else
                {
                    complimentIndex[target - nums[i]] = i;
                }
            }
            return new int[] { -1, -1 };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an array of integers: ");
            string input = Console.ReadLine();
            string[] strList = input.Split(',');
            int[] intList = new int[strList.Length];

            for (int i = 0; i < strList.Length; i++)
            {
                intList[i] = int.Parse(strList[i]);
            }
            Console.Write("Enter a target number: ");
            input = Console.ReadLine();
            int target = int.Parse(input);
            Solution sol = new Solution();
            int[] answer = sol.TwoSum(intList, target);

            Console.WriteLine("The solution is [{0}, {1}]", answer[0], answer[1]);




        }
    }
}
