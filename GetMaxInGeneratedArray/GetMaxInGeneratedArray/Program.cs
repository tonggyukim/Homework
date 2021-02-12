using System;
using System.Linq;

namespace GetMaxInGeneratedArray
{
    class Program
    {
        public int getMaxGeneratedArray (int n)
        {
            int[] array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;
            for (int k=2; k <=n; k++)
            {
                if (k % 2 != 0)
                {
                    int i = (int)k / 2;
                    array[k] = array[i] + array[i + 1];
                }
                else
                {
                    array[k] = array[1];
                }
            }
            int maxValue = array.Max();
            return maxValue;
        }
        static void Main(string[] args)
        {
            Console.Write("Give an integer n: ");
            string input = Console.ReadLine();
            int intInput = int.Parse(input);
            Program solution = new Program();
            int max = solution.getMaxGeneratedArray(intInput);
            Console.WriteLine($"The max of the array is {max}");
        }
    }
}
