using System;
using Math;

namespace LuckyInteger
{
    public class Solution
    {
        public int FindLucky(int[] arr)
        {
            Dictionary<int, int> LuckyNumber = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
			{
                if (LuckyNumber.ContainsKey(arr[i]))
                {
                    LuckyNumber[arr[i]] += 1;
                }
                else
                {
                    LuckyNumber[arr[i]] = 1;
                    //code for putting in k v in dictionary
                }
         
			}
            int maxLuckyNumber = -1;
            foreach (KeyValuePair<int, int> kvp in LuckyNumber)
			{
                if (kvp.Key == kvp.Value)
                {
                    maxLuckyNumber = Math.Max(maxLuckyNumber, kvp.key);
                }
			}

            return maxLuckyNumber;

              

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

