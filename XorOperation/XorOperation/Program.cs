using System;

namespace XorOperation
{
    class Solution
    {
        public int XOrOperator(int n, int start)
        {
            int res = 0;

            for(int i=0; i<n; i++)
            {
                //res ^= (start + 2 * i);
                res = res ^ (start + 2 * i);
            }

            return res;
        }
    }
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("How big should the array be and what should be the starting number?: ");
            string input = Console.ReadLine();
            string[] parameters = input.Split(' ',',');
            if (parameters.Length <2)
            {
                Console.WriteLine("You only entered 1 number");
                return -1;
            }

            string rawMax = parameters[0];
            string rawStartingNumber = parameters[1];
            int convertedMax = int.Parse(rawMax);
            //Console.Write("What should be the starting number?: ");
            //string rawStartingNumber = Console.ReadLine();
            int convertedStartingNumber = int.Parse(rawStartingNumber);
            Solution obj = new Solution();
            int answer = obj.XOrOperator(convertedMax, convertedStartingNumber);
            //int answer = Solution.XOrOperator(convertedMax, convertedStartingNumber);
            Console.WriteLine($"{answer}");
            return 0;
            
            //string[] strList = input.Split(',',' ');
            //int[] intList = new int[strList.Length];
            //for (int i = 0; i<strList.Length; i++)
            //{
            //    intList[i] = int.Parse(strList[i]);
            //}





        }
    }
}
