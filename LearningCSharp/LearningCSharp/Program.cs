using System;

namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[len] = nums[i];
                    len++;
                }
            }
            return len;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sorted integer list: ");
            string input = Console.ReadLine();
            string []strList = input.Split(',');
            int[] intList = new int[strList.Length];

            for (int i = 0; i < strList.Length; i++)
            {
                intList[i] = int.Parse(strList[i]);
            
            }
            Solution sol = new Solution();
            int len = sol.RemoveDuplicates(intList);
            Console.Write("[");
            for (int i = 0; i<len-1; i++)
            {
                Console.Write("{0}{1}", intList[i], ",");
            }
            Console.Write("{0}", intList[intList.Length-1]);
            Console.WriteLine("]");

        }

    }

}



